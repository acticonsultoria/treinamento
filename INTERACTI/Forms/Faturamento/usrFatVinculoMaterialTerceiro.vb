Imports INTERACTI.NFe.RetConsultaSituacaoNFe_V4
Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls
Imports Janus.Windows.UI.Tab
Imports System.Data.SqlClient
Imports System.Globalization
Imports System.IO
Imports System.Reflection
Imports System.Reflection.Assembly
Imports System.Security.Cryptography

Public Class usrFatVinculoMaterialTerceiro

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsUsrFatVinculoMaterialTerceiro As New clsUsrFatVinculoMaterialTerceiro
    Private oClsPrdOrdemProducao As New clsUsrPrdProducaoManual
    Private iFormulario As Integer
    Private lCodigoEntradaCapa As Long
    Private lCodigoEntradaItem As Long

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

    Private Sub usr_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

#End Region

#Region "::: VINCULO DE MATERIAL :::"

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

            'Seta Focus
            dtpDataInicioFiltro.Focus()

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

    Private Sub grdListagem_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdListagem.RowDoubleClick

        Try

            'Verifica se a Célula clicada é Válida
            If IsNothing(grdListagem.CurrentColumn) Then Exit Sub

            Select Case grdListagem.CurrentColumn.Key
                Case "editar" : Editar(grdListagem.GetValue("codigo_entrada_capa"),
                                       grdListagem.GetValue("codigo_entrada_item"))
            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_SizingColumn(sender As Object, e As SizingColumnEventArgs) Handles grdListagem.SizingColumn
        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem.Name,
                                     iFormulario,
                                     e.Column.Key,
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub grdListagem_ColumnMoved(sender As Object, e As ColumnActionEventArgs) Handles grdListagem.ColumnMoved
        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem,
                                     iFormulario)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnInserirVinculo_Click(sender As Object, e As EventArgs) Handles btnInserirVinculo.Click
        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Formulário


            If Validacao() = True Then

                Call SalvarVinculo()

                'Carrega Grid Vinculo
                Call LoadGridVinculos()

                'Prepara Formulário para Inserção de um Novo Registro
                Call NovoVinculo()

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnExcluirVinculo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluirVinculo.Click

        Try

            'Deleta Registros
            Call DeleteVinculo()

            'Prepara Formulário para Inserção de um Novo Registro
            Call NovoVinculo()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnLimparVinculo_Click(sender As Object, e As EventArgs) Handles btnLimparVinculo.Click
        Try

            'Prepara Formulário para Inserção de um Novo Registro
            Call NovoVinculo()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub grdVinculo_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdVinculos.RowDoubleClick

        Try

            'Verifica se foi pressionado uma Célula Válida
            If IsNothing(grdVinculos.CurrentRow) Then Exit Sub

            'Verifica o Tipo de Operação
            Select Case grdVinculos.CurrentColumn.Key

                Case "editar" : Call EditarVinculo()
                Case "numero_os" : Call Visualizar("usrPrdOrdemProducaoManual", grdVinculos.GetValue("codigo_ordem_producao"))

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdVinculo_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdVinculos.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdVinculos,
                                     iFormulario)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdVinculo_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdVinculos.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdVinculos.Name,
                                     iFormulario,
                                     e.Column.Key,
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboOrdemProducaoVinculo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboOrdemProducaoVinculo.SelectedIndexChanged

        Try

            cboRequisisaoEstoqueVinculo.SelectedIndex = -1
            cboRequisisaoEstoqueVinculo.DataSource = Nothing
            cboRequisisaoEstoqueVinculo.Enabled = False

            If cboOrdemProducaoVinculo.SelectedIndex = -1 Then Exit Sub

            cboRequisisaoEstoqueVinculo.Enabled = True
            LoadCombo(cboRequisisaoEstoqueVinculo, "sp_select_combo_faturamento_vinculo_requisicao_estoque " & goUsuario.iEmpresa & ", " & cboOrdemProducaoVinculo.SelectedValue, True)


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

            iFormulario = LoadCodigo("sp_select_static_formulario_codigo_user_control '" & Me.Name & "'")
            iFormularioGrid = iFormulario

            'Adiciona KeyUP
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usr_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Carrega Combos
            LoadCombo(cboUnidadeMedida, "sp_select_combo_cadastro_basico_unidade_medida_sigla " & goUsuario.iEmpresa, False)
            LoadCombo(cboOrdemProducaoVinculo, "sp_select_combo_producao_ordem_producao " & goUsuario.iEmpresa, True)
            LoadCombo(cboUnidadeMedidaVinculo, "sp_select_combo_cadastro_basico_unidade_medida_sigla " & goUsuario.iEmpresa, False)

            cboRequisisaoEstoqueVinculo.Enabled = False

            'Configura Datas
            dtpDataInicioFiltro.Value = DateAdd(DateInterval.Month, -1, Now.Date) : dtpDataInicioFiltro.Checked = True
            dtpDataTerminoFiltro.Value = Now.Date : dtpDataTerminoFiltro.Checked = True

            'Configura Grid
            Call ConfiguraGrid(grdListagem, iFormulario)
            Call ConfiguraGrid(grdVinculos, iFormulario)

            'Remove Aba
            tabMain.TabPages.Remove(pagDados)

            'Seta Focus
            dtpDataInicioFiltro.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: VINCULO DE MATERIAL :::"

    Private Sub LoadGrid()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Seta Cursor do Mouse
            Cursor = Cursors.WaitCursor

            'Carrega Grid
            Call oClsUsrFatVinculoMaterialTerceiro.LoadGrid(oGrid:=grdListagem,
                                                            sNotaFiscal:=txtNFEntradaFiltro.Text,
                                                            sDataInicio:=IIf(dtpDataInicioFiltro.Checked = True, dtpDataInicioFiltro.Value, ""),
                                                            sDataTermino:=IIf(dtpDataTerminoFiltro.Checked = True, dtpDataTerminoFiltro.Value, ""),
                                                            sFornecedor:=txtFornecedorFiltro.Text)

            'Seta Cursor do Mouse
            Cursor = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Editar(ByVal lCodigoCapa As Long,
                       ByVal lCodigoItem As Long)

        Try

            'Verifica se o Usuário tem Direito
            If VerificaDireito(iFormulario, gcInsert) = True Then

                'Novo
                Call Novo()


                lCodigoEntradaCapa = lCodigoCapa
                lCodigoEntradaItem = lCodigoItem

                Call oClsUsrFatVinculoMaterialTerceiro.LoadControles(lCodigoEntradaCapa,
                                                                     lCodigoEntradaItem,
                                                                     txtNFEntrada,
                                                                     txtDataEntradaNF,
                                                                     txtFornecedor,
                                                                     txtCFOP,
                                                                     txtCodigoProduto,
                                                                     txtDescricaoProduto,
                                                                     txtQuantidade,
                                                                     cboUnidadeMedida)

                Call LoadGridVinculos()

                If tabMain.SelectedTab.Name <> pagDados.Name Then
                    'Alterna Aba
                    tabMain.TabPages.Remove(pagListagem)
                    tabMain.TabPages.Add(pagDados)
                End If

            Else
                'Informa o Usuário que ele não possui Direito
                frmMain.Informacao(Mensagem.DireitoInserir)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub LoadGridVinculos()

        Try

            Call oClsUsrFatVinculoMaterialTerceiro.LoadGridVinculos(grdVinculos, lCodigoEntradaCapa, lCodigoEntradaItem)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub
    Private Sub Novo()

        Try


            LimparCamposGroupBox(grpDados)
            NovoVinculo()

            'Limpa grid Vinculo 
            grdVinculos.DataSource = Nothing

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Visualizar(sUserControl As String,
                           lCodigo As Long)

        Try

            Dim sName As String = ""
            Dim sText As String = ""
            Dim bPodeVisualizar As Boolean = False

            Dim oUserControl As UserControl
            Dim oAssembly As Assembly = GetExecutingAssembly()

            oUserControl = oAssembly.CreateInstance("INTERACTI." & sUserControl)
            oUserControl.Dock = DockStyle.Fill
            oUserControl.Tag = "ID:" + CStr(lCodigo)

            Select Case sUserControl
                '1722 - PRODUÇÃO - ORDEM DE PRODUÇÃO - MANUAL
                Case "usrPrdOrdemProducaoManual" : sName = "Ordem Produção" : sText = "Ordem de Produção" : bPodeVisualizar = VerificaDireito(1722, gcSelect)
            End Select

            If bPodeVisualizar = False Then
                frmMain.Informacao(Mensagem.DireitoVisualizar)
                Exit Sub
            End If

            frmMain.LoadPage(sName, sText, oUserControl, True)

            Application.DoEvents()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function Validacao() As Boolean

        Try

            'Seta Retorno da Função
            Validacao = False

            frmMain.errInfo.Clear()

            If ValidaCampo(cboOrdemProducaoVinculo, lblOrdemProducaoVinculo) = False Then Exit Function
            If ValidaCampo(cboRequisisaoEstoqueVinculo, lblRequisisaoEstoqueVinculo) = False Then Exit Function
            If txtQuantidadeVinculo.Value <= 0 Then
                frmMain.errInfo.SetError(lblQuantidadeVinculo, "[" & lblQuantidadeVinculo.Text & "]. Digite um valor válido para ele.")
                txtQuantidadeVinculo.Focus()
                Exit Function
            End If
            If ValidaCampo(cboUnidadeMedidaVinculo, lblUnidadeMedidaVinculo) = False Then Exit Function

            'Seta Retorno da Função
            Validacao = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub SalvarVinculo()

        Try

            ''Verifica o Tipo de Operação
            If IsNumeric(btnInserirVinculo.Tag) Then

                'Atualiza Registro 
                Call oClsUsrFatVinculoMaterialTerceiro.UpdateVinculo(iCodigo:=btnInserirVinculo.Tag,
                                                                     lCodigoEntradaCapa:=lCodigoEntradaCapa,
                                                                     lCodigoEntradaItem:=lCodigoEntradaItem,
                                                                     lCodigoOrdemProducao:=cboOrdemProducaoVinculo.SelectedValue,
                                                                     lCodigoRequisicaoEstoque:=cboRequisisaoEstoqueVinculo.SelectedValue,
                                                                     dQuantidade:=txtQuantidadeVinculo.Value,
                                                                     iCodigoUnidadeMedida:=cboUnidadeMedidaVinculo.SelectedValue)

            Else

                'Insere Registro
                Call oClsUsrFatVinculoMaterialTerceiro.InsertVinculo(lCodigoEntradaCapa:=lCodigoEntradaCapa,
                                                                     lCodigoEntradaItem:=lCodigoEntradaItem,
                                                                     lCodigoOrdemProducao:=cboOrdemProducaoVinculo.SelectedValue,
                                                                     lCodigoRequisicaoEstoque:=cboRequisisaoEstoqueVinculo.SelectedValue,
                                                                     dQuantidade:=txtQuantidadeVinculo.Value,
                                                                     iCodigoUnidadeMedida:=cboUnidadeMedidaVinculo.SelectedValue)


            End If

            frmMain.Informacao(Mensagem.OperacaoRealizadaSucesso)


        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub DeleteVinculo()
        Try

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdVinculos) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, "", "s " & gSelecaoRow.Count) & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro
                    Call oClsUsrFatVinculoMaterialTerceiro.DeleteVinculo(lCodigoEntradaCapa,
                                                                         lCodigoEntradaItem)

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

    Private Sub EditarVinculo()

        Try

            'Verifica se o usuário tem direito de alterar algum registro
            If VerificaDireito(iFormulario, gcUpdate) = True Then

                'Limpa Formulário
                Call NovoVinculo()

                'Carrega Controles
                btnInserirVinculo.Tag = grdVinculos.GetValue("codigo")
                cboOrdemProducaoVinculo.SelectedValue = grdVinculos.GetValue("codigo_ordem_producao")
                cboRequisisaoEstoqueVinculo.SelectedValue = grdVinculos.GetValue("codigo_requisicao_estoque")
                txtQuantidadeVinculo.Value = grdVinculos.GetValue("quantidade")
                cboUnidadeMedidaVinculo.SelectedValue = grdVinculos.GetValue("codigo_unidade_medida")

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub NovoVinculo()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Limpa Controles          
            LimparCamposGroupBox(grpVinculo)
            btnInserirVinculo.Tag = ""

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#End Region


End Class
