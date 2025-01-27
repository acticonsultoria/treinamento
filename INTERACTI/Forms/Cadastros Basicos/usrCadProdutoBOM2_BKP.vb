Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls
Imports Janus.Windows.EditControls
Imports Microsoft.Office.Interop.Excel
Public Class usrCadProdutoBOM2_BKP

#Region "::: VARIAVEIS :::"

    'Variáveis - Classe
    Private oClsCadProduto As New clsUsrCadProduto

    'Váriaveis - Controle
    Private bItemCompra As Boolean
    Private bItemProducao As Boolean
    Private bItemAtivoFixo As Boolean
    Private bItemAlternativo As Boolean

#End Region

#Region "::: CONTROLES :::"

#Region "::: DADOS GERAIS :::"

    Private Sub usrCadProdutoBOM2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.F5

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor
                    Select Case sender.Name
                        Case "cboUnidadeMedida" : Call LoadCombo(cboUnidadeMedida, "sp_select_combo_cadastro_basico_unidade_medida_sigla " & goUsuario.iEmpresa, False)
                    End Select
                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                Case Keys.F3

                    Select Case sender.Name
                        Case "cboCodigoProduto" : Call btnProcurarProduto_Click(btnProcurarItem, System.EventArgs.Empty)
                        Case "cboCodigoItem" : Call btnProcurarItem_Click(btnProcurarItem, System.EventArgs.Empty)
                    End Select

                Case Keys.Oemplus, Keys.Add

                    Select Case sender.Name
                        Case "cboCodigoItem" : Call btnCadastrarItem_Click(btnCadastrarItem, System.EventArgs.Empty)
                        Case "cboUnidadeMedida" : Call btnCadastrarUnidadeMedida_Click(btnCadastrarUnidadeMedida, System.EventArgs.Empty)
                    End Select

                Case Keys.Enter

                    Select Case sender.name
                        Case "cboCodigoProduto" : txtDescricao.Focus()
                    End Select


            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub usrCadProdutoBOM2_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

#End Region

#Region "::: BOM :::"



    Private Sub btnImprimirRelatorio_Click(sender As Object, e As EventArgs) Handles btnImprimirRelatorio.Click
        Try

            'Verifica se foi Selecionado Algum Registro
            If cboCodigoProduto.SelectedIndex <> -1 Then

                'Seta Cursor do Mouse
                Cursor.Current = Cursors.WaitCursor

                'Redimenciona Vetor
                ReDim goCrystalReport.sReportParameter(1)
                'Seta Parametros
                goCrystalReport.sReportParameter(0).sParamenter = "@codigo_item"
                goCrystalReport.sReportParameter(0).sValue = cboCodigoProduto.SelectedValue
                goCrystalReport.sReportParameter(1).sParamenter = "@codigo_empresa"
                goCrystalReport.sReportParameter(1).sValue = goUsuario.iEmpresa
                goCrystalReport.sReport = goCrystalReport.sPath & "rptProducaoFAP.rpt"

                Dim oReport As New usrReport
                oReport.Dock = DockStyle.Fill

                'Abre Relatório
                frmMain.LoadPageReport("rptProducaoFAP", "FAP - Formulário de Análise de Produção", oReport)

                'Seta Cursor do Mouse
                Cursor.Current = Cursors.Default

            Else

                'Informa o Usuário sobre a Necessidade de Selecionar um ou Mais Registros
                frmMain.Informacao(Mensagem.ValidacaoSelecionar)

            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub btnNovoMaterial_Click(sender As Object, e As EventArgs) Handles btnNovoMaterial.Click
        Try

            'Prepara o Formulário para Inserção de um Novo Registro
            Call NovoMaterial()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub trvMain_NodeMouseDoubleClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles trvMain.NodeMouseDoubleClick
        Try
            'Verifica se o Nó é válido
            If IsNothing(e.Node) = True Then Exit Sub

            If IsNothing(e.Node.Parent) = True Then Exit Sub



            'cboCodigoProduto.SelectedValue = cboCodigoItem.SelectedValue
            Call Novo()
            'Verifica se o Nó é válido
            If IsNothing(e.Node) = True Then Exit Sub

            If IsNothing(e.Node.Parent) = True Then Exit Sub

            'Editar Grupo de Item
            Call Editar(e.Node.Tag, _
                        e.Node.Parent.Tag)
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub btnCadastrarItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarItem.Click

        Try

            'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadProduto")

            'Carrega Combo
            Call cboTipoItem_SelectedIndexChanged(cboTipoItem, System.EventArgs.Empty)

            'Seta Focu
            cboCodigoItem.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarUnidadeMedida_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarUnidadeMedida.Click

        Try

            'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadUnidadeMedida")

            'Carrega Combo
            Call LoadCombo(cboUnidadeMedida, "sp_select_combo_cadastro_basico_unidade_medida_sigla " & goUsuario.iEmpresa, False)

            'Seta Focu
            cboUnidadeMedida.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnProcurarProduto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarProduto.Click

        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindItem"
            oForm.Titulo = Me.Parent.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar Produto"

            'Seta Parametros
            iCodigoTipoItemFind = TipoItem.produto
            sItemProducaoFind = "S"
            oComboBoxFind = cboCodigoProduto


            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            cboCodigoProduto.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnProcurarItemOriginal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarItemOriginal.Click

        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindItem"
            oForm.Titulo = Me.Parent.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar Produto"

            'Seta Parametros
            iCodigoTipoItemFind = TipoItem.produto
            oComboBoxFind = cboCodigoItemOriginal

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            cboCodigoItemOriginal.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnProcurarItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarItem.Click

        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindItem"
            oForm.Titulo = Me.Parent.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar Produto"

            'Seta Parametros
            iCodigoTipoItemFind = TipoItem.produto
            sItemCompraFind = IIf(bItemCompra = True, "S", "")
            sItemProducaoFind = IIf(bItemProducao = True, "S", "")
            sItemAtivoFixoFind = IIf(bItemAtivoFixo = True, "S", "")
            oComboBoxFind = cboCodigoItem


            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            cboCodigoItem.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click

        Try

            'Limpa Controles
            frmMain.errInfo.Clear()

            'Verifica se foi Seleciona o Código do Produto
            If ValidaCampo(cboCodigoProduto, lblCodigoProduto) = False Then
                Exit Sub
            End If

            'Imprimir
            Call Imprimir()

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

    Private Sub btnInserir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInserir.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Formulário
            If ValidacaoBOM() = True Then

                'Váriaveis
                Dim lCodigoAntigo As Long = IIf(IsNumeric(btnInserir.Tag), btnInserir.Tag, 0)

                'Verifica o Tipo de Operação
                If IsNumeric(btnInserir.Tag) Then

                    'Atualiza Registro na tb_cad_item_bom
                    Call oClsCadProduto.UpdateBOM(cboCodigoProduto.SelectedValue, _
                                                  cboTipoItem.SelectedValue, _
                                                  cboCodigoItem.SelectedValue, _
                                                  IIf(cboCodigoItemOriginal.SelectedIndex = -1, -1, cboCodigoItemOriginal.SelectedValue), _
                                                  cboUnidadeMedida.SelectedValue, _
                                                  txtQuantidade.Value, _
                                                  txtReferencia.Value, _
                                                  lCodigoAntigo, _
                                                  txtSC.Value, _
                                                  txtDET.Value, _
                                                  txtMP.Text)

                Else

                    'Insere Registro na tb_cad_item_bom
                    Call oClsCadProduto.InsertBOM(cboCodigoProduto.SelectedValue, _
                                                  cboTipoItem.SelectedValue, _
                                                  cboCodigoItem.SelectedValue, _
                                                  IIf(cboCodigoItemOriginal.SelectedIndex = -1, -1, cboCodigoItemOriginal.SelectedValue), _
                                                  cboUnidadeMedida.SelectedValue, _
                                                  txtQuantidade.Value, _
                                                  txtReferencia.Value, _
                                                  txtSC.Value, _
                                                  txtDET.Value, _
                                                  txtMP.Text)

                End If

                'Prepara Formulário para Inserção de um Novo Registro
                Call Novo()

                'Carrega TreeView
                Call LoadTreeView()

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click

        Try

            'Deleta Registros
            Call Delete()

            'Prepara Formulário para Inserção de um Novo Registro
            Call Novo()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboTipoItem_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipoItem.SelectedIndexChanged

        Try

            'Verifica o Tipo de Item - BOM
            If cboTipoItem.SelectedIndex = -1 Then

                'Limpa Controles
                cboCodigoItem.DataSource = Nothing : cboCodigoItem.Text = "" : txtDescricaoItem.Text = ""
                cboCodigoItemOriginal.DataSource = Nothing : cboCodigoItemOriginal.Text = "" : txtDescricaoItemOriginal.Text = "" : cboCodigoItemOriginal.Enabled = False

            Else

                'Carrega Controles
                Call oClsCadProduto.LoadDadosTipoItemBOM(cboTipoItem.SelectedValue, _
                                                         bItemCompra, _
                                                         bItemProducao, _
                                                         bItemAtivoFixo, _
                                                         bItemAlternativo)

                'Verifica se é Alternativo
                If bItemAlternativo = False Then

                    'Desabilita Controle
                    cboCodigoItemOriginal.DataSource = Nothing : cboCodigoItemOriginal.Text = "" : txtDescricaoItemOriginal.Text = "" : cboCodigoItemOriginal.Enabled = False
                    'Carrega Combo
                    Call LoadCombo(cboCodigoItem, "sp_select_combo_cadastro_basico_item " & goUsuario.iEmpresa & ", NULL, NULL, " & TipoItem.produto & ", NULL, null, NULL, " & IIf(bItemAtivoFixo = True, "1", "NULL") & ", NULL", False)

                Else

                    'Desabilita Controle
                    cboCodigoItemOriginal.Enabled = True
                    'Carrega Combo
                    Call LoadCombo(cboCodigoItemOriginal, "sp_select_combo_cadastro_basico_item_bom " & goUsuario.iEmpresa & ", " & cboCodigoProduto.SelectedValue, False)
                    Call LoadCombo(cboCodigoItem, "sp_select_combo_cadastro_basico_item " & goUsuario.iEmpresa & ", NULL, NULL, " & TipoItem.produto & ", NULL, " & IIf(bItemProducao = True, "1", "0") & ", NULL, " & IIf(bItemAtivoFixo = True, "1", "0"), False)

                End If

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboCodigoProduto_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCodigoProduto.SelectedIndexChanged

        Try

            'Verifica se Foi Selecionado algum Registro
            If cboCodigoProduto.SelectedIndex = -1 Then

                'Limpa Controles
                txtDescricao.Text = ""
                cboTipoItem.Text = ""
                cboCodigoItemOriginal.Text = ""
                txtDescricaoItemOriginal.Text = ""
                cboCodigoItem.Text = ""
                txtDescricaoItem.Text = ""
                cboUnidadeMedida.Text = ""
                txtQuantidade.Value = 0
                btnInserir.Tag = ""
                trvMain.Nodes.Clear()

                'Desabilia Controle
                grpDadosMaterial.Enabled = False

            Else

                'Carrega Dados do Produto
                oClsCadProduto.LoadDadosProduto(cboCodigoProduto.SelectedValue, _
                                                txtDescricao)

                'Habilita Controle
                grpDadosMaterial.Enabled = True

                'Carrega TreeView
                Call LoadTreeView()

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboCodigoItemOriginal_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCodigoItemOriginal.SelectedIndexChanged

        Try

            'Verifica se Foi Selecionado algum Registro
            If cboCodigoItemOriginal.SelectedIndex = -1 Then
                'Limpa Controle
                txtDescricaoItemOriginal.Text = ""
            Else
                'Carrega Dados do Produto
                oClsCadProduto.LoadDadosProduto(cboCodigoItemOriginal.SelectedValue, _
                                                txtDescricaoItemOriginal)
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboCodigoItem_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCodigoItem.SelectedIndexChanged

        Try

            'Verifica se Foi Selecionado algum Registro
            If cboCodigoItem.SelectedIndex = -1 Then
                'Limpa Controle
                txtDescricaoItem.Text = ""
            Else
                'Carrega Dados do Produto
                oClsCadProduto.LoadDadosProduto(cboCodigoItem.SelectedValue, _
                                                txtDescricaoItem, _
                                                cboUnidadeMedida)
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub trvMain_NodeMouseClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles trvMain.NodeMouseClick

        Try

            If e.Button = System.Windows.Forms.MouseButtons.Right Then

                If IsNothing(e.Node) Then Exit Sub

                Call Editar(e.Node.Tag, _
                            e.Node.Parent.Tag)

            End If

            ''Verifica se o Nó é válido
            'If IsNothing(e.Node) = True Then Exit Sub

            'If IsNothing(e.Node.Parent) = True Then Exit Sub

            ''Editar Grupo de Item
            'Call Editar(e.Node.Tag, _
            '            e.Node.Parent.Tag)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub


    Private Sub btnLocalizar_Click(sender As Object, e As EventArgs) Handles btnLocalizar.Click
        Try

            ClearBackColor()
            FindByText()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub btnRecolher_Click(sender As Object, e As EventArgs) Handles btnRecolher.Click
        Try

            trvMain.CollapseAll()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub btnExpandir_Click(sender As Object, e As EventArgs) Handles btnExpandir.Click
        Try

            trvMain.ExpandAll()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    'Private Sub btnImportarEstrutura_Click(sender As Object, e As EventArgs) Handles btnImportarEstrutura.Click

    '    Try
    '        frmMain.errInfo.Clear()

    '        If cboCodigoItem.SelectedIndex = -1 Then

    '            If ValidaCampo(cboCodigoItem, lblCodigoItem) = False Then Exit Sub
    '        End If

    '        'Abre Formulário de Cadastro
    '        Dim oForm As New frmCadProdutoBOMImportar
    '        oForm.CodigoProdutoPai = cboCodigoItem.SelectedValue
    '        oForm.NomeProdutoPai = cboCodigoItem.Text

    '        Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

    '        'Carrega Combo
    '        Call cboTipoItem_SelectedIndexChanged(cboTipoItem, System.EventArgs.Empty)

    '        Call LoadTreeView()
    '        frmMain.Informacao(Mensagem.RegistroAlterado)

    '    Catch ex As Exception
    '        'Trata Erro
    '        Call TratamentoErro(ex.Message, Me.Parent.Text)
    '    End Try

    'End Sub
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
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrCadProdutoBOM2_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Verifica Direito
            btnInserir.Enabled = VerificaDireito(Formulario.CadastroBasicoProdutoBOM, gcInsert)
            btnExcluir.Enabled = VerificaDireito(Formulario.CadastroBasicoProdutoBOM, gcDelete)
            btnImprimir.Enabled = VerificaDireito(Formulario.CadastroBasicoProdutoBOM, gcPrint)

            'Verifica Direito - Botão Cadastro
            btnCadastrarItem.Enabled = VerificaDireito(Formulario.CadastroBasicoProdutoBOM, gcInsert)
            btnCadastrarUnidadeMedida.Enabled = VerificaDireito(Formulario.CadastroBasicoUnidadeMedida, gcInsert)

            'Carrega Combo
            Call LoadCombo(cboCodigoProduto, "sp_select_combo_cadastro_basico_item " & goUsuario.iEmpresa & ", NULL, NULL, " & TipoItem.produto & ", NULL, 1, NULL", False)
            Call LoadCombo(cboTipoItem, "sp_select_combo_static_tipo_item_bom")
            Call LoadCombo(cboUnidadeMedida, "sp_select_combo_cadastro_basico_unidade_medida_sigla " & goUsuario.iEmpresa, False)

            'Prepara Formulário
            Call Novo()

            'Seta Focu
            cboCodigoProduto.Focus()


            btnImprimir.Visible = True

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: BOM :::"



    Private Sub NovoMaterial()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            btnInserir.Tag = ""

            'Limpa Controles
            cboTipoItem.SelectedIndex = -1
            cboCodigoItemOriginal.SelectedIndex = -1
            txtDescricaoItemOriginal.Text = ""
            cboCodigoItem.SelectedIndex = -1
            txtDescricaoItem.Text = ""
            txtQuantidade.Value = 0
            cboUnidadeMedida.SelectedIndex = -1
            txtReferencia.Value = 0
            txtPosicao.Text = ""
            txtFind.Text = ""

            'Seta Focu
            cboTipoItem.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Delete()

        Try

            'Verifica se foi selecionado um ou mais registros
            If VerificaSelecaoNode(trvMain) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoNode.Count = 1, " ", "s ") & gSelecaoNode.Count & " registro" & IIf(gSelecaoNode.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro
                    oClsCadProduto.DeleteItemBOMTreeView(cboCodigoProduto.SelectedValue)

                    'Limpa Formulário
                    Call Novo()

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
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub Editar(ByVal lCodigoItem As Long, _
                       ByVal lCodigoItemPai As Long)

        Try

            'Verifica se o usuário tem direito de alterar algum registro
            If VerificaDireito(Formulario.CadastroBasicoProdutoBOM, gcUpdate) = True Then

                'Limpa Formulário
                Call Novo()

                'Carrega Controles
                Call oClsCadProduto.LoadDadosBOM(lCodigoItemPai, _
                                                 lCodigoItem, _
                                                 cboTipoItem, _
                                                 cboCodigoItemOriginal, _
                                                 cboCodigoItem, _
                                                 cboUnidadeMedida, _
                                                 txtQuantidade, _
                                                 txtReferencia, _
                                                 txtPosicao, _
                                                 txtSC, _
                                                 txtDET, _
                                                 txtMP)

                'Seta Controle
                btnInserir.Tag = lCodigoItem

                'Seta Focu
                cboCodigoItem.Focus()

            Else

                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Novo()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Limpa Controles
            cboTipoItem.SelectedValue = 1
            txtReferencia.Value = 1
            txtQuantidade.Value = 0
            cboUnidadeMedida.SelectedIndex = -1
            cboCodigoItem.SelectedIndex = -1
            txtPosicao.Text = ""
            btnInserir.Tag = ""

            txtMP.Text = ""
            txtSC.Value = 0
            txtDET.Value = 0

            'Seta Focu
            cboCodigoItem.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub LoadTreeView()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Limpa TreeView
            trvMain.Nodes.Clear()

            'Seta Parametros
            Call oClsCadProduto.LoadTreeViewBOM(trvMain, cboCodigoProduto.SelectedValue)

            'Expand Nós
            'trvMain.ExpandAll()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub
    Private Sub Imprimir()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Variaveis Local
            Dim oApplicationClass As New Application
            Dim oWorkbook As Workbook
            Dim oWorksheet As Worksheet


            oWorkbook = oApplicationClass.Workbooks.Add()
            oWorksheet = oWorkbook.ActiveSheet()


            oApplicationClass.Cells(1, 1) = "Produto"
            oApplicationClass.Cells(1, 2) = "Codigo 2"
            oApplicationClass.Cells(1, 3) = "Descrição"
            oApplicationClass.Cells(1, 4) = "Nível"
            oApplicationClass.Cells(1, 5) = "Quantidade"
            oApplicationClass.Cells(1, 6) = "Quantidade Total"



            oApplicationClass.Cells(1, 1).font.bold = True
            oApplicationClass.Cells(1, 2).font.bold = True
            oApplicationClass.Cells(1, 3).font.bold = True
            oApplicationClass.Cells(1, 4).font.bold = True
            oApplicationClass.Cells(1, 5).font.bold = True
            oApplicationClass.Cells(1, 6).font.bold = True



            Dim sInputBox As String = InputBox("Digite a quantidade do Part Number final:", "Quantidade final")

            If Not IsNumeric(sInputBox) Then Exit Sub

            Dim iRegistro As Integer = 2

            'Laço de repetição para imprimir os nós
            For Each oNode As TreeNode In trvMain.Nodes





                Dim sCodigoProduto As String
                Dim sCodigo2 As String
                Dim sDescricao As String
                Dim sTipo As String
                Dim sOrigem As String
                Dim dQuantidade As Double
                Dim sUnidadeMedida As String


                Dim sGrupoItem As String
                Dim sSubgrupo1 As String
                Dim sD1Subgrupo1 As String
                Dim sD2Subgrupo1 As String
                Dim sSubgrupo2 As String
                Dim sD1Subgrupo2 As String
                Dim sRevisao As String

                'Carrega os dados
                oClsCadProduto.LoadDadosExportarBOM(-1, oNode.Tag, dQuantidade, sCodigoProduto, sCodigo2, sDescricao, sTipo, sOrigem, sUnidadeMedida, sGrupoItem, sSubgrupo1, sD1Subgrupo1, sD2Subgrupo1, sSubgrupo2, sD1Subgrupo2, sRevisao)


                oApplicationClass.Cells(iRegistro, 1) = sCodigoProduto
                oApplicationClass.Cells(iRegistro, 2) = sCodigo2
                oApplicationClass.Cells(iRegistro, 3) = sDescricao
                oApplicationClass.Cells(iRegistro, 4) = 1
                oApplicationClass.Cells(iRegistro, 5) = dQuantidade
                oApplicationClass.Cells(iRegistro, 6) = dQuantidade * CDbl(sInputBox)


                oApplicationClass.Rows(iRegistro).Select()
                oApplicationClass.Selection.Interior.color = 5296274

                'Imprime recursivamente 
                ImprimirNO(oApplicationClass, oNode, 1, iRegistro, dQuantidade * CDbl(sInputBox))


            Next


            'Abre Formulário            
            oWorksheet.Columns.AutoFit()
            oApplicationClass.Visible = True



            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub
    Private Sub ImprimirNO(ByRef oApplicationClass As Application, _
                           ByRef oNode As TreeNode, _
                           ByRef iNivel As Integer, _
                           ByRef iRegistro As Integer, _
                           ByRef dQuantidadeTotal As Double)

        Try



            'Incrementa o nivel
            iNivel += 1

            Dim iNivelInicial As Integer = iNivel


            For Each oNodeFilho As TreeNode In oNode.Nodes

                'Incrementa a linha
                iRegistro += 1



                Dim sCodigoProduto As String
                Dim sCodigo2 As String
                Dim sDescricao As String
                Dim sTipo As String
                Dim sOrigem As String
                Dim dQuantidade As Double
                Dim sUnidadeMedida As String


                Dim sGrupoItem As String
                Dim sSubgrupo1 As String
                Dim sD1Subgrupo1 As String
                Dim sD2Subgrupo1 As String
                Dim sSubgrupo2 As String
                Dim sD1Subgrupo2 As String

                Dim sRevisao As String



                'Carrega os dados
                oClsCadProduto.LoadDadosExportarBOM(oNode.Tag, oNodeFilho.Tag, dQuantidade, sCodigoProduto, sCodigo2, sDescricao, sTipo, sOrigem, sUnidadeMedida, sGrupoItem, sSubgrupo1, sD1Subgrupo1, sD2Subgrupo1, sSubgrupo2, sD1Subgrupo2, sRevisao)


                oApplicationClass.Cells(iRegistro, 1) = sCodigoProduto
                oApplicationClass.Cells(iRegistro, 2) = sCodigo2
                oApplicationClass.Cells(iRegistro, 3) = sDescricao
                oApplicationClass.Cells(iRegistro, 4) = iNivel
                oApplicationClass.Cells(iRegistro, 5) = dQuantidade
                oApplicationClass.Cells(iRegistro, 6) = dQuantidade * dQuantidadeTotal

                'Indenta
                oApplicationClass.Cells(iRegistro, 1).InsertIndent(iNivel)



                oApplicationClass.Rows(iRegistro).Select()
                Select Case iNivel
                    Case 1 : oApplicationClass.Selection.Interior.color = 5296274
                    Case 2 : oApplicationClass.Selection.Interior.color = 10471931
                    Case 3 : oApplicationClass.Selection.Interior.color = 16751001
                    Case 4 : oApplicationClass.Selection.Interior.color = 16750848
                    Case 5 : oApplicationClass.Selection.Interior.color = 12632256
                    Case 6 : oApplicationClass.Selection.Interior.color = 8650220

                End Select



                'Escreve os filhos 
                ImprimirNO(oApplicationClass, oNodeFilho, iNivel, iRegistro, dQuantidade * dQuantidadeTotal)

                'Volta para o nivel anterior
                iNivel = iNivelInicial

            Next

        Catch ex As Exception
            Throw ex
        End Try

    End Sub
    'Private Sub Imprimir()

    '    Try

    '        'Seta Cursor do Mouse
    '        Cursor.Current = Cursors.WaitCursor

    '        'Redimenciona Vetor
    '        ReDim goCrystalReport.sReportParameter(1)
    '        'Seta Parametros
    '        goCrystalReport.sReportParameter(0).sParamenter = "@codigo_item"
    '        goCrystalReport.sReportParameter(0).sValue = cboCodigoProduto.SelectedValue
    '        goCrystalReport.sReportParameter(1).sParamenter = "@codigo_empresa"
    '        goCrystalReport.sReportParameter(1).sValue = goUsuario.iEmpresa
    '        goCrystalReport.sReport = goCrystalReport.sPath & "CAD000000005.rpt"

    '        Dim oReport As New usrReport
    '        oReport.Dock = DockStyle.Fill

    '        'Abre Relatório
    '        frmMain.LoadPageReport("CAD000000005", "Cadastro Básico - BOM", oReport)

    '        'Seta Cursor do Mouse
    '        Cursor.Current = Cursors.Default

    '    Catch ex As Exception
    '        'Trata Erro
    '        Call TratamentoErro(ex.Message, Me.Parent.Text)
    '    End Try

    'End Sub

    Private Function ValidacaoBOM() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoBOM = False

            'Verifica se foi Selecionado o Campo - Produto
            If ValidaCampo(cboCodigoProduto, lblCodigoProduto) = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Tipo de Item
            If ValidaCampo(cboTipoItem, lblTipoItem) = False Then
                Exit Function
            End If

            'Verifiva se foi Selecionado o Campo - Código
            If ValidaCampo(cboCodigoItem, lblCodigoItem) = False Then
                Exit Function
            ElseIf oClsCadProduto.ValidaCodigoBOM(cboCodigoProduto.SelectedValue, _
                                                  cboCodigoItem.SelectedValue, _
                                                  IIf(IsNumeric(btnInserir.Tag), btnInserir.Tag, -1)) = False Then
                frmMain.errInfo.SetError(lblCodigoItem, "Este Item já se encontra associado ao Produto: " & cboCodigoProduto.SelectedValue)
                cboCodigoItem.Focus()
                Exit Function
            End If

            'Verifica se o Código do Produto é igual o Código do Item
            If cboCodigoProduto.SelectedValue = cboCodigoItem.SelectedValue Then
                frmMain.errInfo.SetError(lblCodigoItem, "O Código da Matéria Prima não pode ser o mesmo Código do Produto.")
                cboCodigoItem.Focus()
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Código Original
            If cboCodigoItemOriginal.Enabled = True Then
                If ValidaCampo(cboCodigoItemOriginal, lblCodigoItemOriginal) = False Then
                    Exit Function
                ElseIf cboCodigoItem.SelectedValue = cboCodigoItemOriginal.SelectedValue Then
                    frmMain.errInfo.SetError(lblCodigoItem, "O Código da Matéria Prima Alternativa, não pode ser igual ao Código da Matéria Prima Original.")
                    cboCodigoItem.Focus()
                    Exit Function
                End If
            End If

            'Verifica se foi Preenchido o Campo - Referência
            If ValidaCampo(txtReferencia, lblReferencia, True) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Quantidade
            If ValidaCampo(txtQuantidade, lblQuantidade, True) = False Then
                Exit Function
            End If

            'Verifiva se foi Selecionado o Campo - Unidade de Medida
            If ValidaCampo(cboUnidadeMedida, lblUnidadeMedida) = False Then
                Exit Function
            End If

            'Seta Retorno da Função
            ValidacaoBOM = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#End Region

#Region "::: FIND :::"

    Private Sub FindByText()
        Dim nodes As TreeNodeCollection = trvMain.Nodes
        Dim n As TreeNode
        For Each n In nodes
            FindRecursive(n)
        Next
    End Sub

    Private Sub FindRecursive(ByVal tNode As TreeNode)
        If txtFind.Text = "" Then
            trvMain.CollapseAll()
            trvMain.BackColor = Color.White
            'ExpandToLevel(trvMain.Nodes, 1)

        Else
            Dim tn As TreeNode
            For Each tn In tNode.Nodes
                ' if the text properties match, color the item
                If tn.Text.Contains(txtFind.Text) Then
                    tn.BackColor = Color.Yellow
                    tn.EnsureVisible()        'Scroll the control to the item
                End If

                FindRecursive(tn)
            Next
        End If
    End Sub

    Private Sub ClearBackColor()
        Dim nodes As TreeNodeCollection
        nodes = trvMain.Nodes
        Dim n As TreeNode
        For Each n In nodes
            ClearRecursive(n)
        Next
    End Sub

    Private Sub ClearRecursive(ByVal treeNode As TreeNode)
        Dim tn As TreeNode
        For Each tn In treeNode.Nodes
            tn.BackColor = Color.White
            ClearRecursive(tn)
        Next
    End Sub

#End Region

End Class