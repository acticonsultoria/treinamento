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

Public Class usrEstApontamentoSobra

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsUsrEstApontamentoSobra As New clsUsrEstApontamentoSobra
    Private oClsPrdOrdemProducao As New clsUsrPrdProducaoManual
    Private iFormulario As Integer
    Private lCodigoMovimentacao As Long

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

    Private Sub usr_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize

        'Reposiciona UserControl
        Me.Top = (frmMain.picImage.Top + ((frmMain.picImage.Height - Me.Height) / 2))
        Me.Left = ((frmMain.picImage.Width - Me.Width) / 2)

    End Sub

#End Region

#Region "::: APONTAMENTO SOBRAS :::"

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

                Case "editar" : Editar(grdListagem.GetValue("codigo_movimentacao"))
                Case "numero_os" : Visualizar("usrPrdOrdemProducaoManual", grdListagem.GetValue("codigo_ordem_producao"))
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

    Private Sub btnInserirApontamento_Click(sender As Object, e As EventArgs) Handles btnInserirApontamento.Click
        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Formulário


            If Validacao() = True Then

                Call SalvarApontamento()

                'Carrega Grid Apontamento
                Call oClsUsrEstApontamentoSobra.LoadGridApontamento(grdApontamento, lCodigoMovimentacao)

                'Prepara Formulário para Inserção de um Novo Registro
                Call LimparApontamento()

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnExcluirApontamento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluirApontamento.Click

        Try

            'Deleta Registros
            Call DeleteApontamento()

            'Prepara Formulário para Inserção de um Novo Registro
            Call LimparApontamento()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnLimparApontamento_Click(sender As Object, e As EventArgs) Handles btnLimparApontamento.Click
        Try

            'Limpa o apontamento
            Call LimparApontamento()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub grdApontamento_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdApontamento.RowDoubleClick

        Try

            'Verifica se foi pressionado uma Célula Válida
            If IsNothing(grdApontamento.CurrentRow) Then Exit Sub

            'Verifica o Tipo de Operação
            Select Case grdApontamento.CurrentColumn.Key

                'BTN visible = false no primeiro momento
                'Case "editar" : Call EditarApontamento()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdApontamento_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdApontamento.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdApontamento,
                                     iFormulario)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdApontamento_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdApontamento.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdApontamento.Name,
                                     iFormulario,
                                     e.Column.Key,
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub Peso_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtQuantidadeApontamento.LostFocus,
                                                                                            txtMedida1.LostFocus,
                                                                                            txtMedida2.LostFocus,
                                                                                            txtMedida3.LostFocus,
                                                                                            txtMedida4.LostFocus

        Try

            CalculaPesoTeorico()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnFindGrupoItem_Click(sender As Object, e As EventArgs)
        Try

            NovoApontamento()

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindGrupoItem2"
            oForm.Titulo = Me.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar Grupo de Item"

            cboGrupoItem.Tag = ""

            'Seta Parametros
            oComboBoxFind = cboCodigoProduto
            oComboBoxFindGrupoItemProduto = cboGrupoItem

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            cboGrupoItem.Focus()

            'Se for ferramnenta
            If sGrupoItemFerramentaConcatenado <> "" Then

                txtCodigoProdutoNovo.Text = LoadCodigo("sp_select_cadastro_basico_grupo_item_concatenado_ferramenta " & goUsuario.iEmpresa & "," & "'" & sGrupoItemFerramentaConcatenado & "','CODIGO'")
                txtDescricaoApontamento.Text = LoadCodigo("sp_select_cadastro_basico_grupo_item_concatenado_ferramenta " & goUsuario.iEmpresa & "," & "'" & sGrupoItemFerramentaConcatenado & "','DESCRIÇÃO'")

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub cboCodigoProduto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCodigoProduto.SelectedIndexChanged
        Try

            If cboCodigoProduto.SelectedIndex = -1 Then

                lblCodigoProdutoNovoRequisicaoListaMaterial.Visible = True : txtCodigoProdutoNovo.Visible = True
                Exit Sub

            End If

            lblCodigoProdutoNovoRequisicaoListaMaterial.Visible = False : txtCodigoProdutoNovo.Visible = False
            txtDescricaoApontamento.Text = LoadCodigo("sp_load_cadastro_basico_produto_descricao " & cboCodigoProduto.SelectedValue & "," & goUsuario.iEmpresa)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try
    End Sub

    Private Sub cboGrupoItem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboGrupoItem.SelectedIndexChanged
        Try

            If cboGrupoItem.SelectedIndex = -1 Then Exit Sub

            LoadCombo(cboCodigoProduto, "sp_select_combo_cadastro_basico_item " & goUsuario.iEmpresa & ",null,null")
            txtDescricaoApontamento.Text = LoadCodigo("sp_select_cadastro_basico_grupo_item_composicao " & cboGrupoItem.SelectedValue & "," & goUsuario.iEmpresa & ",'SIGLA'")
            txtCodigoProdutoNovo.Text = LoadCodigo("sp_select_cadastro_basico_grupo_item_composicao " & cboGrupoItem.SelectedValue & "," & goUsuario.iEmpresa & ",'CODIGO'")

            Dim iCodigoMaterial As Integer
            Dim icodigoTipoPerfil As Integer

            'Carrega os dados baseado na estrutura de grupo de item
            LoadDadosGrupoItem(cboGrupoItem.SelectedValue,
                                                        iCodigoTipoPerfil:=icodigoTipoPerfil,
                                                        iCodigoMaterial:=iCodigoMaterial,
                                                        iCodigoFamilia:=-1,
                                                        iCodigoTipoItemSPED:=-1)

            cboGrupoItem.Tag = CStr(icodigoTipoPerfil) & "|" & CStr(iCodigoMaterial)

            LoadMaterial()
            LoadTipoPerfil()


        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
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
            LoadCombo(cboGrupoItem, "sp_select_combo_cadastro_basico_grupo_item " & goUsuario.iEmpresa)
            LoadCombo(cboCodigoProduto, "sp_select_combo_cadastro_basico_produto_producao " & goUsuario.iEmpresa, False)

            'Configura Datas
            dtpDataInicioFiltro.Value = DateAdd(DateInterval.Month, -1, Now.Date) : dtpDataInicioFiltro.Checked = True
            dtpDataTerminoFiltro.Value = Now.Date : dtpDataTerminoFiltro.Checked = True

            'Configura Grid
            Call ConfiguraGrid(grdListagem, iFormulario)
            Call ConfiguraGrid(grdApontamento, iFormulario)

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

#Region "::: APONTAMENTO SOBRAS :::"

    Private Sub LoadGrid()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Seta Cursor do Mouse
            Cursor = Cursors.WaitCursor

            'Carrega Grid
            Call oClsUsrEstApontamentoSobra.LoadGrid(oGrid:=grdListagem,
                                          sDataInicio:=IIf(dtpDataInicioFiltro.Checked = True, dtpDataInicioFiltro.Value, ""),
                                          sDataTermino:=IIf(dtpDataTerminoFiltro.Checked = True, dtpDataTerminoFiltro.Value, ""))

            'Seta Cursor do Mouse
            Cursor = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Editar(ByVal lCodigo As Long)

        Try

            'Verifica se o Usuário tem Direito
            If VerificaDireito(iFormulario, gcInsert) = True Then

                'Novo
                Call Novo()


                lCodigoMovimentacao = lCodigo

                Call oClsUsrEstApontamentoSobra.LoadControles(lCodigoMovimentacao,
                                                              txtOrdemProducao:=txtOrdemProducao,
                                                              txtDataMovimentacao:=txtDataMovimentacao,
                                                              txtNumeroRE:=txtNumeroRE,
                                                              txtCodigoProduto:=txtCodigoProduto,
                                                              txtDescricaoProduto:=txtDescricaoProduto,
                                                              txtUnidadeMedida:=txtUnidadeMedida,
                                                              txtQuantidadeMovimentacaoEstoque:=txtQuantidadeMovimentacaoEstoque,
                                                              txtQuantidadeRE:=txtQuantidadeRE,
                                                              txtQuantidadeDiferenca:=txtQuantidadeDiferenca,
                                                              cboGrupoItem:=cboGrupoItem,
                                                              cboUnidadeMedida:=cboUnidadeMedida)

                Call oClsUsrEstApontamentoSobra.LoadGridApontamento(grdApontamento, lCodigoMovimentacao)

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

    Private Sub Novo()

        Try


            LimparCamposGroupBox(grpDados)
            NovoApontamento()

            'Limpa grid Apontamento 
            grdApontamento.DataSource = Nothing

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

            If ValidaCampo(cboGrupoItem, lblGrupoItemRequisicaoListaMaterial) = False Then Exit Function
            If ValidaCampo(cboUnidadeMedida, lblUnidadeMedidaApontamento) = False Then Exit Function
            If ValidaCampo(txtQuantidadeApontamento, lblQuantidadeApontamento, TipoCampo.numero) = False Then Exit Function

            If oClsUsrEstApontamentoSobra.ValidaDimensao(lCodigoMovimentacao, _
                                                         txtMedida1.Value, _
                                                         txtMedida2.Value, _
                                                         txtMedida3.Value, _
                                                         txtMedida4.Value, _
                                                         txtPeso.Value) = False Then
                MsgBox("As dimensões ou peso total apontados não correspondem ao item pai", MsgBoxStyle.Exclamation, "Validação")
                Exit Function
            End If


            'Seta Retorno da Função
            Validacao = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub SalvarApontamento()

        Try

            Dim lCodigoItem As Long = LoadCodigo("sp_load_lista_material_codigo_item_medidas " &
                                     cboGrupoItem.SelectedValue & ", " &
                                     txtMedida1.Value.ToString().Replace(",", ".") & ", " &
                                     txtMedida2.Value.ToString().Replace(",", ".") & ", " &
                                     txtMedida3.Value.ToString().Replace(",", ".") & ", " &
                                     txtMedida4.Value.ToString().Replace(",", ".") & ", " &
                                     goUsuario.iEmpresa)

            Dim sCodigoProduto As String = LoadCodigo("sp_load_lista_material_codigo_produto " & lCodigoItem & ", " & goUsuario.iEmpresa)

            If lCodigoItem = -1 Then

                'Cadastrar o item e altera o valor da variavel
                lCodigoItem = oClsPrdOrdemProducao.InsertCadastroBasicoProdutoOP(cboGrupoItem.SelectedValue,
                                                                                 txtDescricaoApontamento.Text.Trim,
                                                                                 txtCodigoProdutoNovo.Text,
                                                                                 txtMedida1.Value,
                                                                                 txtMedida2.Value,
                                                                                 txtMedida3.Value,
                                                                                 txtMedida4.Value,
                                                                                 cboUnidadeMedida.SelectedValue,
                                                                                 -1,
                                                                                 "")
                sCodigoProduto = txtCodigoProdutoNovo.Text

            End If

            'Verifica o Tipo de Operação
            If IsNumeric(btnInserirApontamento.Tag) Then

                'Atualiza Registro --> O btn deve ficar visible = false no primero momento. 
                Call oClsUsrEstApontamentoSobra.UpdateApontamento(lCodigoMovimentacao:=lCodigoMovimentacao,
                                                                  iCodigoApontamento:=btnInserirApontamento.Tag,
                                                                  lCodigoGrupoItem:=IIf(cboGrupoItem.SelectedIndex = -1, -1, cboGrupoItem.SelectedValue),
                                                                  lCodigoProduto:=lCodigoItem,
                                                                  dMedida1:=txtMedida1.Value,
                                                                  dMedida2:=txtMedida2.Value,
                                                                  dMedida3:=txtMedida3.Value,
                                                                  dMedida4:=txtMedida4.Value,
                                                                  iCodigoUnidadeMedida:=IIf(cboUnidadeMedida.SelectedIndex = -1, -1, cboUnidadeMedida.SelectedValue),
                                                                  dQuantidade:=txtQuantidadeApontamento.Value,
                                                                  dPeso:=txtPeso.Value)

            Else

                'Insere Registro
                Call oClsUsrEstApontamentoSobra.InsertApontamento(lCodigoMovimentacao:=lCodigoMovimentacao,
                                                                  lCodigoGrupoItem:=IIf(cboGrupoItem.SelectedIndex = -1, -1, cboGrupoItem.SelectedValue),
                                                                  lCodigoProduto:=lCodigoItem,
                                                                  dMedida1:=txtMedida1.Value,
                                                                  dMedida2:=txtMedida2.Value,
                                                                  dMedida3:=txtMedida3.Value,
                                                                  dMedida4:=txtMedida4.Value,
                                                                  iCodigoUnidadeMedida:=IIf(cboUnidadeMedida.SelectedIndex = -1, -1, cboUnidadeMedida.SelectedValue),
                                                                  dQuantidade:=txtQuantidadeApontamento.Value,
                                                                  dPeso:=txtPeso.Value)

            End If

            frmMain.Informacao(Mensagem.OperacaoRealizadaSucesso)


        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub DeleteApontamento()
        Try

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdApontamento) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, "", "s " & gSelecaoRow.Count) & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro
                    Call oClsUsrEstApontamentoSobra.DeleteApontamento(lCodigoMovimentacao)

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

    Private Sub EditarApontamento()

        Try

            'Verifica se o usuário tem direito de alterar algum registro
            If VerificaDireito(iFormulario, gcUpdate) = True Then

                'Limpa Formulário
                Call NovoApontamento()

                'Carrega Controles
                btnInserirApontamento.Tag = grdApontamento.CurrentRow.Cells("codigo").Value
                cboCodigoProduto.SelectedValue = grdApontamento.CurrentRow.Cells("codigo_produto").Value
                cboGrupoItem.SelectedValue = grdApontamento.CurrentRow.Cells("codigo_grupo_item").Value
                txtMedida1.Value = grdApontamento.CurrentRow.Cells("medida1").Value
                txtMedida2.Value = grdApontamento.CurrentRow.Cells("medida2").Value
                txtMedida3.Value = grdApontamento.CurrentRow.Cells("medida3").Value
                txtMedida4.Value = grdApontamento.CurrentRow.Cells("medida4").Value
                'cboUnidadeMedida.SelectedValue = grdApontamento.CurrentRow.Cells("codigo_unidade_medida").Value
                cboUnidadeMedida.SelectedValue = 2
                txtQuantidadeApontamento.Value = grdApontamento.CurrentRow.Cells("quantidade").Value
                txtPeso.Value = grdApontamento.CurrentRow.Cells("peso").Value
                txtDescricaoApontamento.Text = grdApontamento.CurrentRow.Cells("descricao").Value

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub NovoApontamento()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Limpa Controles          
            LimparCamposGroupBox(grpApontamento)
            btnInserirApontamento.Tag = ""

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub LimparApontamento()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Limpa Controles          
            Dim medidas() As NumericEditBox = {txtMedida1, txtMedida2, txtMedida3, txtMedida4}

            ' Limpa Controles
            For Each medida As NumericEditBox In medidas
                If Not medida.ReadOnly Then
                    medida.Value = 0
                End If
            Next

            txtQuantidadeApontamento.Value = 0
            txtDescricaoApontamento.Text = ""
            btnInserirApontamento.Tag = ""
            cboCodigoProduto.SelectedIndex = -1

            txtCodigoProdutoNovo.Text = LoadCodigo("sp_select_cadastro_basico_grupo_item_composicao " & cboGrupoItem.SelectedValue & "," & goUsuario.iEmpresa & ",'CODIGO'")

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub LoadTipoPerfil()

        Try

            txtMedida1.Enabled = False : txtMedida1.Value = 0
            txtMedida2.Enabled = False : txtMedida2.Value = 0
            txtMedida3.Enabled = False : txtMedida3.Value = 0
            txtMedida4.Enabled = False : txtMedida4.Value = 0

            CalculaPesoTeorico()

            LoadMedidas()

            CalculaPesoTeorico()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub LoadMedidas()
        Try

            Dim sCodigoTipoPerfil As String = -1

            Try
                sCodigoTipoPerfil = cboGrupoItem.Tag.ToString.Split("|")(0)
            Catch ex As Exception
                Throw ex
            End Try

            Dim sGrupoItemFinal As String = ObterGrupo(cboGrupoItem.Text)

            If sCodigoTipoPerfil = "-1" Then Exit Sub

            Dim iQuantidadeMedidas As Integer = LoadCodigo("sp_load_cadastro_basico_tipo_perfil_quantidade_medidas " & sCodigoTipoPerfil & "," & goUsuario.iEmpresa)
            Dim sMedida1 As String = LoadCodigo("sp_load_cadastro_basico_tipo_perfil_descricao_medida " & sCodigoTipoPerfil & ", 1, " & goUsuario.iEmpresa)
            Dim sMedida2 As String = LoadCodigo("sp_load_cadastro_basico_tipo_perfil_descricao_medida " & sCodigoTipoPerfil & ", 2, " & goUsuario.iEmpresa)
            Dim sMedida3 As String = LoadCodigo("sp_load_cadastro_basico_tipo_perfil_descricao_medida " & sCodigoTipoPerfil & ", 3, " & goUsuario.iEmpresa)
            Dim sMedida4 As String = LoadCodigo("sp_load_cadastro_basico_tipo_perfil_descricao_medida " & sCodigoTipoPerfil & ", 4, " & goUsuario.iEmpresa)

            Dim lCodigoItem As Long = IIf(cboCodigoProduto.SelectedIndex = -1, -1, cboCodigoProduto.SelectedValue)

            Dim dMedida1 As Double = LoadCodigo("sp_load_cadastro_basico_produto_medida " & lCodigoItem & "," & goUsuario.iEmpresa & "," & 1)
            Dim dMedida2 As Double = LoadCodigo("sp_load_cadastro_basico_produto_medida " & lCodigoItem & "," & goUsuario.iEmpresa & "," & 2)
            Dim dMedida3 As Double = LoadCodigo("sp_load_cadastro_basico_produto_medida " & lCodigoItem & "," & goUsuario.iEmpresa & "," & 3)
            Dim dMedida4 As Double = LoadCodigo("sp_load_cadastro_basico_produto_medida " & lCodigoItem & "," & goUsuario.iEmpresa & "," & 4)
            Dim iCodigoUnidadeMedida As Integer = LoadCodigo("sp_load_cadastro_basico_produto_medida " & lCodigoItem & "," & goUsuario.iEmpresa & "," & 5)

            'Se tiver selecionado um item, bloqueia todas as medidas 
            If lCodigoItem <> -1 Then
                txtMedida1.ReadOnly = True
                txtMedida1.BackColor = Color.WhiteSmoke

                txtMedida2.ReadOnly = True
                txtMedida2.BackColor = Color.WhiteSmoke

                txtMedida3.ReadOnly = True
                txtMedida3.BackColor = Color.WhiteSmoke

                txtMedida4.ReadOnly = True
                txtMedida4.BackColor = Color.WhiteSmoke
            Else
                txtMedida1.ReadOnly = False
                txtMedida1.BackColor = Color.White

                txtMedida2.ReadOnly = False
                txtMedida2.BackColor = Color.White

                txtMedida3.ReadOnly = False
                txtMedida3.BackColor = Color.White

                txtMedida4.ReadOnly = False
                txtMedida4.BackColor = Color.White
            End If

            'Trata as medidas do grupo de item
            Select Case iQuantidadeMedidas

                Case 1
                    txtMedida1.Enabled = True
                    lblMedida1.Text = sMedida1 + ":"

                    If IsNumeric(dMedida1) And dMedida1 > 0 Then

                        txtMedida1.Value = dMedida1

                    ElseIf IsNumeric(sGrupoItemFinal) Then

                        txtMedida1.ReadOnly = True
                        txtMedida1.BackColor = Color.WhiteSmoke
                        txtMedida1.Text = Convert.ToDouble(sGrupoItemFinal.Replace(",", "."), CultureInfo.InvariantCulture)

                    End If

                Case 2
                    txtMedida1.Enabled = True
                    txtMedida2.Enabled = True

                    lblMedida1.Text = sMedida1 + ":"
                    lblMedida2.Text = sMedida2 + ":"

                    If IsNumeric(dMedida1) And dMedida1 > 0 Then

                        txtMedida1.Value = dMedida1

                    ElseIf IsNumeric(sGrupoItemFinal) Then

                        txtMedida1.ReadOnly = True
                        txtMedida1.BackColor = Color.WhiteSmoke
                        txtMedida1.Text = Convert.ToDouble(sGrupoItemFinal.Replace(",", "."), CultureInfo.InvariantCulture)

                    End If

                    If IsNumeric(dMedida2) And dMedida2 > 0 Then
                        txtMedida2.Value = dMedida2
                    End If

                Case 3
                    txtMedida1.Enabled = True
                    txtMedida2.Enabled = True
                    txtMedida3.Enabled = True

                    lblMedida1.Text = sMedida1 + ":"
                    lblMedida2.Text = sMedida2 + ":"
                    lblMedida3.Text = sMedida3 + ":"

                    If IsNumeric(dMedida1) And dMedida1 > 0 Then

                        txtMedida1.Value = dMedida1

                    ElseIf IsNumeric(sGrupoItemFinal) Then

                        txtMedida1.ReadOnly = True
                        txtMedida1.BackColor = Color.WhiteSmoke
                        txtMedida1.Text = Convert.ToDouble(sGrupoItemFinal.Replace(",", "."), CultureInfo.InvariantCulture)

                    End If

                    If IsNumeric(dMedida2) And dMedida2 > 0 Then
                        txtMedida2.Value = dMedida2
                    End If

                    If IsNumeric(dMedida3) And dMedida3 > 0 Then
                        txtMedida3.Value = dMedida3
                    End If

                Case 4
                    txtMedida1.Enabled = True
                    txtMedida2.Enabled = True
                    txtMedida3.Enabled = True
                    txtMedida4.Enabled = True

                    lblMedida1.Text = sMedida1 + ":"
                    lblMedida2.Text = sMedida2 + ":"
                    lblMedida3.Text = sMedida3 + ":"
                    lblMedida4.Text = sMedida4 + ":"

                    If IsNumeric(dMedida1) And dMedida1 > 0 Then

                        txtMedida1.Value = dMedida1

                    ElseIf IsNumeric(sGrupoItemFinal) Then

                        txtMedida1.ReadOnly = True
                        txtMedida1.BackColor = Color.WhiteSmoke
                        txtMedida1.Text = Convert.ToDouble(sGrupoItemFinal.Replace(",", "."), CultureInfo.InvariantCulture)

                    End If

                    If IsNumeric(dMedida2) And dMedida2 > 0 Then
                        txtMedida2.Value = dMedida2
                    End If

                    If IsNumeric(dMedida3) And dMedida3 > 0 Then
                        txtMedida3.Value = dMedida3
                    End If

                    If IsNumeric(dMedida4) And dMedida4 > 0 Then
                        txtMedida4.Value = dMedida4
                    End If

            End Select



        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub LoadMaterial()

        Try

            txtPesoEspecifico.Value = 0


            Dim sCodigoMaterial As String = -1
            Try
                sCodigoMaterial = cboGrupoItem.Tag.ToString.Split("|")(1)
            Catch ex As Exception

            End Try

            If sCodigoMaterial = "-1" Then Exit Sub

            txtPesoEspecifico.Value = LoadCodigo("sp_load_cadastro_basico_material_densidade " & sCodigoMaterial & "," & goUsuario.iEmpresa)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub CalculaPesoTeorico()

        Try

            Dim sCodigoTipoPerfil As String = -1

            If cboGrupoItem.Tag Is Nothing Then Exit Sub

            If cboGrupoItem.Tag.ToString = "" Then Exit Sub

            Try
                sCodigoTipoPerfil = cboGrupoItem.Tag.ToString.Split("|")(0)
            Catch ex As Exception

            End Try


            Dim oScriptControl As New MSScriptControl.ScriptControl
            Dim oScriptControlPesoConsiderado As New MSScriptControl.ScriptControl
            Dim sCalculo As String
            Dim sCalculoPesoConsiderado As String
            Dim dQuantidade As Double = txtQuantidadeApontamento.Value
            Dim dMedida1 As Double = txtMedida1.Value
            Dim dMedida2 As Double = txtMedida2.Value
            Dim dMedida3 As Double = txtMedida3.Value
            Dim dMedida4 As Double = txtMedida4.Value
            Dim dPesoEspecifico As Double = txtPesoEspecifico.Value
            Dim sFormula As String = LoadCodigo("sp_load_cadastro_basico_tipo_perfil_formula " & sCodigoTipoPerfil & "," & goUsuario.iEmpresa)

            oScriptControl.Language = "VBScript"
            oScriptControlPesoConsiderado.Language = "VBScript"

            'Altera Valores Da Fórmula
            sCalculo = Replace(sFormula, "|MEDIDA_1|", dMedida1)
            sCalculo = Replace(sCalculo, "|MEDIDA_2|", dMedida2)
            sCalculo = Replace(sCalculo, "|MEDIDA_3|", dMedida3)
            sCalculo = Replace(sCalculo, "|MEDIDA_4|", dMedida4)
            sCalculo = Replace(sCalculo, "|PESO_ESP|", dPesoEspecifico)
            sCalculo = Replace(sCalculo, ",", ".")

            'Efetua Cálculo
            txtPeso.Value = oScriptControl.Eval(sCalculo) * dQuantidade

            txtDescricaoApontamento.Text = LoadCodigo("sp_select_cadastro_basico_grupo_item_composicao " & cboGrupoItem.SelectedValue & "," & goUsuario.iEmpresa & ",'SIGLA'")

            If txtMedida1.Value > 0.0 Then
                If txtMedida2.Value = 0.0 And txtMedida3.Value = 0.0 And txtMedida4.Value = 0.0 Then
                    ' Se houver apenas a primeira medida, usa " X "
                    txtDescricaoApontamento.Text += " X " & FormatNumber(txtMedida1.Value, 2)
                Else
                    ' Se houver mais medidas, usa " - " para a primeira
                    txtDescricaoApontamento.Text += " - " & FormatNumber(txtMedida1.Value, 2)
                End If
            End If

            txtDescricaoApontamento.Text += IIf(txtMedida2.Value > 0.0, " X " + FormatNumber(txtMedida2.Value, 2), "")
            txtDescricaoApontamento.Text += IIf(txtMedida3.Value > 0.0, " X " + FormatNumber(txtMedida3.Value, 2), "")
            txtDescricaoApontamento.Text += IIf(txtMedida4.Value > 0.0, " X " + FormatNumber(txtMedida4.Value, 2), "")
            If txtQuantidadeApontamento.Value > 0 Then
                txtDescricaoApontamento.Text += IIf(txtPeso.Value > 0.0, " (" + FormatNumber(txtPeso.Value / txtQuantidadeApontamento.Value, 2) & " KG )", "")
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function ObterGrupo(texto As String) As String

        Try

            Dim ultimaBarra As Integer = texto.LastIndexOf("/")

            If ultimaBarra >= 0 Then
                Dim ultimaParte As String = texto.Substring(ultimaBarra + 1).Trim()
                Return ultimaParte
            Else
                Return texto
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#End Region


End Class
