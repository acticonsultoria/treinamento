Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls
Imports Janus.Windows.EditControls
Imports Microsoft.Office.Interop.Excel
Public Class usrCadProdutoBOM2

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

    Private Sub btnCadastrarItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarItem.Click

        Try

            'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadProduto")


            Call LoadCombo(cboCodigoItem, "sp_select_combo_cadastro_basico_item " & goUsuario.iEmpresa & ", NULL, NULL, " & TipoItem.produto)


            'Seta Focu
            cboCodigoItem.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarUnidadeMedida_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

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

                'Codigo antigo, definido no botão de editar (lápis)
                Dim lCodigoAntigo As Long = IIf(IsNumeric(cboCodigoItem.Tag), cboCodigoItem.Tag, 0)

                'Verifica o Tipo de Operação
                If IsNumeric(btnInserir.Tag) Then

                    'Atualiza Registro na tb_cad_item_bom
                    oClsCadProduto.UpdateBOMGrid(cboCodigoProduto.SelectedValue, _
                                                 cboCodigoItem.SelectedValue, _
                                                 -1, _
                                                 cboUnidadeMedida.SelectedValue, _
                                                 txtQuantidade.Value, _
                                                 1, _
                                                 lCodigoAntigo, _
                                                 txtSC.Value, _
                                                 txtDET.Value, _
                                                 txtMP.Text, _
                                                 IIf(txtComprimento.Visible = True, txtComprimento.Value, 0), _
                                                 IIf(txtLargura.Visible = True, txtLargura.Value, 0), _
                                                 IIf(txtAltura.Visible = True, txtAltura.Value, 0), _
                                                 txtDimensao.Text, _
                                                 IIf(cboUnidadeMedidaDimensao.SelectedIndex = -1, -1, cboUnidadeMedidaDimensao.SelectedValue), _
                                                 IIf(cboUnidadeMedidaQuantidade.SelectedIndex = -1, -1, cboUnidadeMedidaQuantidade.SelectedValue), _
                                                 IIf(cboNivelInspecao.SelectedIndex = -1, -1, cboNivelInspecao.SelectedValue), _
                                                 btnInserir.Tag)

                Else

                    'Insere Registro na tb_cad_item_bom
                    oClsCadProduto.InsertBOMGrid(cboCodigoProduto.SelectedValue, _
                                                 cboCodigoItem.SelectedValue, _
                                                 -1, _
                                                 cboUnidadeMedida.SelectedValue, _
                                                 txtQuantidade.Value, _
                                                 1, _
                                                 txtSC.Value, _
                                                 txtDET.Value, _
                                                 txtMP.Text, _
                                                 IIf(txtComprimento.Visible = True, txtComprimento.Value, 0), _
                                                 IIf(txtLargura.Visible = True, txtLargura.Value, 0), _
                                                 IIf(txtAltura.Visible = True, txtAltura.Value, 0), _
                                                 txtDimensao.Text, _
                                                 IIf(cboUnidadeMedidaDimensao.SelectedIndex = -1, -1, cboUnidadeMedidaDimensao.SelectedValue), _
                                                 IIf(cboUnidadeMedidaQuantidade.SelectedIndex = -1, -1, cboUnidadeMedidaQuantidade.SelectedValue), _
                                                 IIf(cboNivelInspecao.SelectedIndex = -1, -1, cboNivelInspecao.SelectedValue))
                End If

                'Prepara Formulário para Inserção de um Novo Registro
                Novo()

                'Carrega Grid
                LoadGrid()

            End If

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
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

    Private Sub btnVoltarItem_Click(sender As Object, e As EventArgs) Handles btnVoltarItem.Click

        Try

            cboCodigoProduto.SelectedValue = txtItemAnterior.Tag

        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboCodigoProduto_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCodigoProduto.SelectedIndexChanged

        Try

            'Verifica se Foi Selecionado algum Registro
            If cboCodigoProduto.SelectedIndex = -1 Then

                'Limpa Controles
                txtDescricao.Text = ""

                cboCodigoItem.Text = ""
                txtDescricaoItem.Text = ""
                cboUnidadeMedida.Text = ""
                txtQuantidade.Value = 0
                txtItemAnterior.Text = ""
                txtItemAnterior.Tag = ""
                btnInserir.Tag = ""

                'Desabilia Controle
                grpDadosMaterial.Enabled = False

            Else


                'Carrega Dados do Produto
                oClsCadProduto.LoadDadosProduto(cboCodigoProduto.SelectedValue, _
                                                txtDescricao)

                'Habilita Controle
                grpDadosMaterial.Enabled = True

                'Carrega Grid
                Call LoadGrid()

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
                oClsCadProduto.LoadDadosProdutoBOM(cboCodigoItem.SelectedValue, _
                                                txtDescricaoItem, _
                                                cboUnidadeMedida, _
                                                txtSC, _
                                                txtDET, _
                                                cboNivelInspecao)


                If txtSC.Text = 0 Then

                    txtSC.ReadOnly = False
                    txtSC.BackColor = Color.White

                    txtDET.ReadOnly = False
                    txtDET.BackColor = Color.White

                Else

                    txtSC.ReadOnly = True
                    txtSC.BackColor = Color.WhiteSmoke

                    txtDET.ReadOnly = True
                    txtDET.BackColor = Color.WhiteSmoke

                End If

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboUnidadeMedida_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboUnidadeMedida.SelectedIndexChanged
        Try
            'Carrega os controles
            oClsCadProduto.LoadControlesDimensao(cboCodigoItem.SelectedValue, _
                                                 cboUnidadeMedida, _
                                                 lblComprimento, _
                                                 lblLargura, _
                                                 lblAltura, _
                                                 txtComprimento, _
                                                 txtLargura, _
                                                 txtAltura)

            grpDimensao.Visible = True
            If txtComprimento.Visible = True Or txtLargura.Visible = True Or txtAltura.Visible = True Then
                grpDimensao.Visible = True
            Else
                grpDimensao.Visible = False
            End If

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub Dimensao_Changed() Handles txtComprimento.TextChanged, txtLargura.TextChanged, txtAltura.TextChanged

        Try
            txtDimensao.Text = ""

            If txtComprimento.Value > 0 Then

                txtDimensao.Text = txtComprimento.Text

            End If

            If txtLargura.Value > 0 Then

                txtDimensao.Text = txtDimensao.Text + IIf(txtDimensao.Text <> "", " x ", "") + CStr(txtLargura.Text)

            End If


            If txtAltura.Value > 0 Then

                txtDimensao.Text = txtDimensao.Text + IIf(txtDimensao.Text <> "", " x ", "") + CStr(txtAltura.Text)

            End If


        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        Try

            Call Imprimir()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub grdListagem_CellEdited(sender As Object, e As ColumnActionEventArgs) Handles grdListagem.CellEdited

    End Sub

    Private Sub grdListagem_CurrentCellChanged(sender As Object, e As EventArgs) Handles grdListagem.CurrentCellChanged
        Try

            'Select Case grdListagem.CurrentColumn.Key

            '    Case "industrializacao", "item_compra"
            'oClsCadProduto.UpdateBOMTipoProduto(grdListagem.CurrentRow.Cells.Item("codigo_item").Value, _
            '                                    grdListagem.CurrentRow.Cells.Item("industrializacao").Value, _
            '                                    grdListagem.CurrentRow.Cells.Item("item_compra").Value)

            '    Case "industrializacao2", "item_compra2"
            '        oClsCadProduto.UpdateBOMTipoProduto(grdListagem.CurrentRow.Cells.Item("codigo_item2").Value, _
            '                       grdListagem.CurrentRow.Cells.Item("industrializacao2").Value, _
            '                       grdListagem.CurrentRow.Cells.Item("item_compra2").Value)

            '    Case "industrializacao3", "item_compra3"
            '        oClsCadProduto.UpdateBOMTipoProduto(grdListagem.CurrentRow.Cells.Item("codigo_item3").Value, _
            '                        grdListagem.CurrentRow.Cells.Item("industrializacao3").Value, _
            '                       grdListagem.CurrentRow.Cells.Item("item_compra3").Value)



            'End Select



        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub grdListagem_CurrentCellChanging(sender As Object, e As CurrentCellChangingEventArgs) Handles grdListagem.CurrentCellChanging
        Try

            'Select Case grdListagem.CurrentColumn.Key

            '    Case "industrializacao", "item_compra"
            '        oClsCadProduto.UpdateBOMTipoProduto(grdListagem.CurrentRow.Cells.Item("codigo_item").Value, _
            '                                            grdListagem.CurrentRow.Cells.Item("industrializacao").Value, _
            '                                            grdListagem.CurrentRow.Cells.Item("item_compra").Value)

            '    Case "industrializacao2", "item_compra2"
            '        oClsCadProduto.UpdateBOMTipoProduto(grdListagem.CurrentRow.Cells.Item("codigo_item2").Value, _
            '                       grdListagem.CurrentRow.Cells.Item("industrializacao2").Value, _
            '                       grdListagem.CurrentRow.Cells.Item("item_compra2").Value)

            '    Case "industrializacao3", "item_compra3"
            '        oClsCadProduto.UpdateBOMTipoProduto(grdListagem.CurrentRow.Cells.Item("codigo_item3").Value, _
            '                        grdListagem.CurrentRow.Cells.Item("industrializacao3").Value, _
            '                       grdListagem.CurrentRow.Cells.Item("item_compra3").Value)



            'End Select



        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub grdListagem_EditingCell(sender As Object, e As EditingCellEventArgs) Handles grdListagem.EditingCell
        Try

            'Select Case grdListagem.CurrentColumn.Key

            '    Case "industrializacao", "item_compra"
            '        oClsCadProduto.UpdateBOMTipoProduto(grdListagem.CurrentRow.Cells.Item("codigo_item").Value, _
            '                                            grdListagem.CurrentRow.Cells.Item("industrializacao").Value, _
            '                                            grdListagem.CurrentRow.Cells.Item("item_compra").Value)

            '    Case "industrializacao2", "item_compra2"
            '        oClsCadProduto.UpdateBOMTipoProduto(grdListagem.CurrentRow.Cells.Item("codigo_item2").Value, _
            '                       grdListagem.CurrentRow.Cells.Item("industrializacao2").Value, _
            '                       grdListagem.CurrentRow.Cells.Item("item_compra2").Value)

            '    Case "industrializacao3", "item_compra3"
            '        oClsCadProduto.UpdateBOMTipoProduto(grdListagem.CurrentRow.Cells.Item("codigo_item3").Value, _
            '                        grdListagem.CurrentRow.Cells.Item("industrializacao3").Value, _
            '                       grdListagem.CurrentRow.Cells.Item("item_compra3").Value)



            'End Select



        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub btnCompararRequisicao_Click(sender As Object, e As EventArgs) Handles btnCompararRequisicao.Click

        Try

            If ValidaCampo(cboCodigoProduto, lblCodigoProduto) = False Then Exit Sub

            'Váriaveis - Formulário
            Dim oForm As New frmCadProdutoBOMRequisicao

            oForm.CodigoItem = cboCodigoProduto.SelectedValue
            oForm.ShowDialog(Me)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub grdListagem_RowDoubleClick(sender As Object, e As RowActionEventArgs) Handles grdListagem.RowDoubleClick
        Try
            'Verifica se a Linha é Válida
            If IsNothing(grdListagem.CurrentColumn) Then Exit Sub

            Select Case grdListagem.CurrentColumn.Key

                Case "editar1" : Editar(grdListagem.CurrentRow.Cells.Item("codigo_item_pai").Value, _
                                            grdListagem.CurrentRow.Cells.Item("codigo_item").Value, _
                                            grdListagem.CurrentRow.Cells.Item("quantidade").Value, _
                                            grdListagem.CurrentRow.Cells.Item("codigo_unidade_medida").Value, _
                                            IIf(IsDBNull(grdListagem.CurrentRow.Cells.Item("sub_conjunto").Value), 0, grdListagem.CurrentRow.Cells.Item("sub_conjunto").Value), _
                                            IIf(IsDBNull(grdListagem.CurrentRow.Cells.Item("detalhe").Value), 0, grdListagem.CurrentRow.Cells.Item("detalhe").Value), _
                                            IIf(IsDBNull(grdListagem.CurrentRow.Cells.Item("materia_prima").Value), "", grdListagem.CurrentRow.Cells.Item("materia_prima").Value), _
                                            IIf(IsDBNull(grdListagem.CurrentRow.Cells.Item("comprimento").Value), 0, grdListagem.CurrentRow.Cells.Item("comprimento").Value), _
                                            IIf(IsDBNull(grdListagem.CurrentRow.Cells.Item("largura").Value), 0, grdListagem.CurrentRow.Cells.Item("largura").Value), _
                                            IIf(IsDBNull(grdListagem.CurrentRow.Cells.Item("altura").Value), 0, grdListagem.CurrentRow.Cells.Item("altura").Value), _
                                            IIf(IsDBNull(grdListagem.CurrentRow.Cells.Item("codigo_unidade_medida_dimensao").Value), -1, grdListagem.CurrentRow.Cells.Item("codigo_unidade_medida_dimensao").Value), _
                                            IIf(IsDBNull(grdListagem.CurrentRow.Cells.Item("codigo_unidade_medida_quantidade").Value), -1, grdListagem.CurrentRow.Cells.Item("codigo_unidade_medida_quantidade").Value), _
                                            IIf(IsDBNull(grdListagem.CurrentRow.Cells.Item("codigo_nivel_inspecao").Value), -1, grdListagem.CurrentRow.Cells.Item("codigo_nivel_inspecao").Value), _
                                            grdListagem.CurrentRow.Cells.Item("codigo").Value)

                Case "editar2" : Editar(grdListagem.CurrentRow.Cells.Item("codigo_item_pai2").Value, _
                                        grdListagem.CurrentRow.Cells.Item("codigo_item2").Value, _
                                        grdListagem.CurrentRow.Cells.Item("quantidade2").Value, _
                                        grdListagem.CurrentRow.Cells.Item("codigo_unidade_medida2").Value, _
                                        IIf(IsDBNull(grdListagem.CurrentRow.Cells.Item("sub_conjunto2").Value), 0, grdListagem.CurrentRow.Cells.Item("sub_conjunto2").Value), _
                                        IIf(IsDBNull(grdListagem.CurrentRow.Cells.Item("detalhe2").Value), 0, grdListagem.CurrentRow.Cells.Item("detalhe2").Value), _
                                        IIf(IsDBNull(grdListagem.CurrentRow.Cells.Item("materia_prima2").Value), "", grdListagem.CurrentRow.Cells.Item("materia_prima2").Value), _
                                        IIf(IsDBNull(grdListagem.CurrentRow.Cells.Item("comprimento2").Value), 0, grdListagem.CurrentRow.Cells.Item("comprimento2").Value), _
                                        IIf(IsDBNull(grdListagem.CurrentRow.Cells.Item("largura2").Value), 0, grdListagem.CurrentRow.Cells.Item("largura2").Value), _
                                        IIf(IsDBNull(grdListagem.CurrentRow.Cells.Item("altura2").Value), 0, grdListagem.CurrentRow.Cells.Item("altura2").Value), _
                                        IIf(IsDBNull(grdListagem.CurrentRow.Cells.Item("codigo_unidade_medida_dimensao2").Value), -1, grdListagem.CurrentRow.Cells.Item("codigo_unidade_medida_dimensao2").Value), _
                                        IIf(IsDBNull(grdListagem.CurrentRow.Cells.Item("codigo_unidade_medida_quantidade2").Value), -1, grdListagem.CurrentRow.Cells.Item("codigo_unidade_medida_quantidade2").Value), _
                                        IIf(IsDBNull(grdListagem.CurrentRow.Cells.Item("codigo_nivel_inspecao2").Value), -1, grdListagem.CurrentRow.Cells.Item("codigo_nivel_inspecao2").Value), _
                                        grdListagem.CurrentRow.Cells.Item("codigo2").Value)

                Case "editar3" : Editar(grdListagem.CurrentRow.Cells.Item("codigo_item_pai3").Value, _
                                        grdListagem.CurrentRow.Cells.Item("codigo_item3").Value, _
                                        grdListagem.CurrentRow.Cells.Item("quantidade3").Value, _
                                        grdListagem.CurrentRow.Cells.Item("codigo_unidade_medida3").Value, _
                                        IIf(IsDBNull(grdListagem.CurrentRow.Cells.Item("sub_conjunto3").Value), 0, grdListagem.CurrentRow.Cells.Item("sub_conjunto3").Value), _
                                        IIf(IsDBNull(grdListagem.CurrentRow.Cells.Item("detalhe3").Value), 0, grdListagem.CurrentRow.Cells.Item("detalhe3").Value), _
                                        IIf(IsDBNull(grdListagem.CurrentRow.Cells.Item("materia_prima3").Value), "", grdListagem.CurrentRow.Cells.Item("materia_prima3").Value), _
                                        IIf(IsDBNull(grdListagem.CurrentRow.Cells.Item("comprimento3").Value), 0, grdListagem.CurrentRow.Cells.Item("comprimento3").Value), _
                                        IIf(IsDBNull(grdListagem.CurrentRow.Cells.Item("largura3").Value), 0, grdListagem.CurrentRow.Cells.Item("largura3").Value), _
                                        IIf(IsDBNull(grdListagem.CurrentRow.Cells.Item("altura3").Value), 0, grdListagem.CurrentRow.Cells.Item("altura3").Value), _
                                        IIf(IsDBNull(grdListagem.CurrentRow.Cells.Item("codigo_unidade_medida_dimensao3").Value), -1, grdListagem.CurrentRow.Cells.Item("codigo_unidade_medida_dimensao3").Value), _
                                        IIf(IsDBNull(grdListagem.CurrentRow.Cells.Item("codigo_unidade_medida_quantidade3").Value), -1, grdListagem.CurrentRow.Cells.Item("codigo_unidade_medida_quantidade3").Value), _
                                        IIf(IsDBNull(grdListagem.CurrentRow.Cells.Item("codigo_nivel_inspecao3").Value), -1, grdListagem.CurrentRow.Cells.Item("codigo_nivel_inspecao3").Value), _
                                        grdListagem.CurrentRow.Cells.Item("codigo3").Value)

                Case "editar4" : Editar(grdListagem.CurrentRow.Cells.Item("codigo_item_pai4").Value, _
                                        grdListagem.CurrentRow.Cells.Item("codigo_item4").Value, _
                                        grdListagem.CurrentRow.Cells.Item("quantidade4").Value, _
                                        grdListagem.CurrentRow.Cells.Item("codigo_unidade_medida4").Value, _
                                        IIf(IsDBNull(grdListagem.CurrentRow.Cells.Item("sub_conjunto4").Value), 0, grdListagem.CurrentRow.Cells.Item("sub_conjunto4").Value), _
                                        IIf(IsDBNull(grdListagem.CurrentRow.Cells.Item("detalhe4").Value), 0, grdListagem.CurrentRow.Cells.Item("detalhe4").Value), _
                                        IIf(IsDBNull(grdListagem.CurrentRow.Cells.Item("materia_prima4").Value), "", grdListagem.CurrentRow.Cells.Item("materia_prima4").Value), _
                                        IIf(IsDBNull(grdListagem.CurrentRow.Cells.Item("comprimento4").Value), 0, grdListagem.CurrentRow.Cells.Item("comprimento4").Value), _
                                        IIf(IsDBNull(grdListagem.CurrentRow.Cells.Item("largura4").Value), 0, grdListagem.CurrentRow.Cells.Item("largura4").Value), _
                                        IIf(IsDBNull(grdListagem.CurrentRow.Cells.Item("altura4").Value), 0, grdListagem.CurrentRow.Cells.Item("altura4").Value), _
                                        IIf(IsDBNull(grdListagem.CurrentRow.Cells.Item("codigo_unidade_medida_dimensao4").Value), -1, grdListagem.CurrentRow.Cells.Item("codigo_unidade_medida_dimensao4").Value), _
                                        IIf(IsDBNull(grdListagem.CurrentRow.Cells.Item("codigo_unidade_medida_quantidade4").Value), -1, grdListagem.CurrentRow.Cells.Item("codigo_unidade_medida_quantidade4").Value), _
                                        IIf(IsDBNull(grdListagem.CurrentRow.Cells.Item("codigo_nivel_inspecao4").Value), -1, grdListagem.CurrentRow.Cells.Item("codigo_nivel_inspecao4").Value), _
                                        grdListagem.CurrentRow.Cells.Item("codigo4").Value)

                Case "topo" : Topo(grdListagem.CurrentRow.Cells.Item("codigo_item").Value)
                Case "topo2" : Topo(grdListagem.CurrentRow.Cells.Item("codigo_item2").Value)
                Case "topo3" : Topo(grdListagem.CurrentRow.Cells.Item("codigo_item3").Value)
                Case "topo4" : Topo(grdListagem.CurrentRow.Cells.Item("codigo_item4").Value)

            End Select

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnCadastrarItemLote_Click(sender As Object, e As EventArgs) Handles btnCadastrarItemLote.Click
        Try

            'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadItemLote")

            'Carrega Combo
            Call cboCodigoProduto_SelectedIndexChanged(cboCodigoProduto, System.EventArgs.Empty)

            Call LoadCombo(cboCodigoProduto, "sp_select_combo_cadastro_basico_item " & goUsuario.iEmpresa & ", NULL, NULL, " & TipoItem.produto & ", NULL, 1, NULL", False)
            Call LoadCombo(cboCodigoItem, "sp_select_combo_cadastro_basico_item " & goUsuario.iEmpresa & ", NULL, NULL, " & TipoItem.produto)


            'Seta Focu
            cboCodigoProduto.Focus()



        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub grdListagem_UpdatingRecord(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles grdListagem.UpdatingRecord
        Try

            Select Case grdListagem.CurrentColumn.Key

                Case "industrializacao", "item_compra"
                    oClsCadProduto.UpdateBOMTipoProduto(grdListagem.CurrentRow.Cells.Item("codigo_item").Value, _
                                                        grdListagem.CurrentRow.Cells.Item("industrializacao").Value, _
                                                        grdListagem.CurrentRow.Cells.Item("item_compra").Value)

                Case "industrializacao2", "item_compra2"
                    oClsCadProduto.UpdateBOMTipoProduto(grdListagem.CurrentRow.Cells.Item("codigo_item2").Value, _
                                   grdListagem.CurrentRow.Cells.Item("industrializacao2").Value, _
                                   grdListagem.CurrentRow.Cells.Item("item_compra2").Value)

                Case "industrializacao3", "item_compra3"
                    oClsCadProduto.UpdateBOMTipoProduto(grdListagem.CurrentRow.Cells.Item("codigo_item3").Value, _
                                    grdListagem.CurrentRow.Cells.Item("industrializacao3").Value, _
                                   grdListagem.CurrentRow.Cells.Item("item_compra3").Value)



            End Select



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
            Call LoadCombo(cboCodigoItem, "sp_select_combo_cadastro_basico_item " & goUsuario.iEmpresa & ", NULL, NULL, " & TipoItem.produto)
            Call LoadCombo(cboUnidadeMedida, "sp_select_combo_cadastro_basico_unidade_medida_sigla " & goUsuario.iEmpresa, False)
            Call LoadCombo(cboUnidadeMedidaDimensao, "sp_select_combo_cadastro_basico_unidade_medida_sigla " & goUsuario.iEmpresa, False)
            Call LoadCombo(cboUnidadeMedidaQuantidade, "sp_select_combo_cadastro_basico_unidade_medida_sigla " & goUsuario.iEmpresa, False)
            Call LoadCombo(cboNivelInspecao, "sp_select_combo_static_nivel_inspecao", False)

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


            cboCodigoItem.SelectedIndex = -1
            txtDescricaoItem.Text = ""
            txtQuantidade.Value = 0
            cboUnidadeMedida.SelectedIndex = -1


        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Delete()

        Try

            'Verifica se foi selecionado um ou mais registros
            If VerificaSelecaoRow(grdListagem) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir os registros?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro
                    oClsCadProduto.DeleteItemBOM(cboCodigoProduto.SelectedValue)

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

    Private Sub Novo()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Limpa Controles

            txtQuantidade.Value = 0
            cboUnidadeMedida.SelectedIndex = -1
            cboCodigoItem.SelectedIndex = -1
            cboUnidadeMedidaQuantidade.SelectedValue = 4

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

    Private Sub LoadGrid()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor


            'Seta Parametros
            oClsCadProduto.LoadBOMGridTeste(grdListagem, _
                                       cboCodigoProduto.SelectedValue)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function ValidacaoBOM() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoBOM = False

            'Verifica se foi Selecionado o Campo - Produto
            If ValidaCampo(cboCodigoProduto, lblCodigoProduto) = False Then
                Exit Function
            End If


            'Verifiva se foi Selecionado o Campo - Código
            If ValidaCampo(cboCodigoItem, lblCodigoItem) = False Then
                Exit Function
            ElseIf oClsCadProduto.ValidaCodigoBOM(cboCodigoProduto.SelectedValue, _
                                                  cboCodigoItem.SelectedValue, _
                                                  IIf(IsNumeric(btnInserir.Tag), btnInserir.Tag, -1), _
                                                  txtMP.Text) = False And IsNumeric(btnInserir.Tag) = False Then
                frmMain.errInfo.SetError(lblCodigoItem, "Este Item já se encontra associado ao Produto: " & cboCodigoProduto.Text)
                cboCodigoItem.Focus()
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

            If grpDimensao.Visible = True Then

                If ValidaCampo(cboUnidadeMedidaDimensao, lblUnidadeMedidaDimensao) = False Then
                    Exit Function
                End If

            End If

            'Seta Retorno da Função
            ValidacaoBOM = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub Editar(ByVal iCodigoItemPai As Integer, _
                  ByVal iCodigoItem As Integer, _
                  ByVal dQuantidade As Double, _
                  ByVal iCodigoUnidadeMedida As Integer, _
                  ByVal iSC As Integer, _
                  ByVal iDET As Integer, _
                  ByVal sMP As String, _
                  ByVal dComprimento As Double, _
                  ByVal dLargura As Double, _
                  ByVal dAltura As Double, _
                  ByVal iCodigoUnidadeMedidaDimensao As Integer, _
                  ByVal iCodigoUnidadeMedidaQuantidade As Integer, _
                  ByVal iCodigoNivelInspecao As Integer, _
                  ByVal iCodigo As Integer)
        Try

            'Codigo Pai
            cboCodigoProduto.SelectedValue = iCodigoItemPai

            'Codigo Filho
            cboCodigoItem.SelectedValue = iCodigoItem
            cboCodigoItem.Tag = iCodigoItem 'como usuário pode querer alterar o item com o update, guarda-se o código

            cboUnidadeMedida.SelectedValue = iCodigoUnidadeMedida
            txtQuantidade.Value = dQuantidade
            txtSC.Value = iSC
            txtDET.Value = iDET
            txtMP.Text = sMP
            btnInserir.Tag = iCodigo

            txtComprimento.Value = dComprimento
            txtLargura.Value = dLargura
            txtAltura.Value = dAltura


            If iCodigoUnidadeMedidaDimensao = -1 Then
                cboUnidadeMedidaDimensao.SelectedIndex = -1
            Else
                cboUnidadeMedidaDimensao.SelectedValue = iCodigoUnidadeMedidaDimensao
            End If

            If iCodigoUnidadeMedidaQuantidade = -1 Then
                cboUnidadeMedidaQuantidade.SelectedIndex = -1
            Else
                cboUnidadeMedidaQuantidade.SelectedValue = iCodigoUnidadeMedidaQuantidade
            End If

            If iCodigoNivelInspecao = -1 Then
                cboNivelInspecao.SelectedIndex = -1
            Else
                cboNivelInspecao.SelectedValue = iCodigoNivelInspecao
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Topo(ByVal iCodigoItem As Integer)

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            If oClsCadProduto.VerificaEdicaoBOM(iCodigoItem) = False Then
                frmMain.Informacao(Mensagem.OperacaoNaoRealizada, "Não é possível editar matéria prima.")
                Exit Sub
            End If


            txtItemAnterior.Text = cboCodigoProduto.Text
            txtItemAnterior.Tag = cboCodigoProduto.SelectedValue
            cboCodigoProduto.SelectedValue = iCodigoItem

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
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
            oApplicationClass.Cells(1, 5) = "Un. Medida"
            oApplicationClass.Cells(1, 6) = "Quantidade"
            oApplicationClass.Cells(1, 7) = "Quantidade Total"
            oApplicationClass.Cells(1, 8) = "SC"
            oApplicationClass.Cells(1, 9) = "DET"
            oApplicationClass.Cells(1, 10) = "MP"
            oApplicationClass.Cells(1, 11) = "Dimensão"
            oApplicationClass.Cells(1, 12) = "Un. Medida Dimensão"

            oApplicationClass.Cells(1, 1).font.bold = True
            oApplicationClass.Cells(1, 2).font.bold = True
            oApplicationClass.Cells(1, 3).font.bold = True
            oApplicationClass.Cells(1, 4).font.bold = True
            oApplicationClass.Cells(1, 5).font.bold = True
            oApplicationClass.Cells(1, 6).font.bold = True
            oApplicationClass.Cells(1, 7).font.bold = True
            oApplicationClass.Cells(1, 8).font.bold = True
            oApplicationClass.Cells(1, 9).font.bold = True
            oApplicationClass.Cells(1, 10).font.bold = True
            oApplicationClass.Cells(1, 11).font.bold = True
            oApplicationClass.Cells(1, 12).font.bold = True

            Dim sInputBox As String = InputBox("Digite a quantidade do Part Number final:", "Quantidade final")

            If Not IsNumeric(sInputBox) Then Exit Sub

            Dim iRegistro As Integer = 2

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

            Dim sSC As String
            Dim sDET As String
            Dim sMP As String
            Dim sDimensao As String
            Dim sUnidadeDimensao As String

            'Carrega os dados
            oClsCadProduto.LoadDadosExportarBOM(-1, _
                                                cboCodigoProduto.SelectedValue, _
                                                dQuantidade, _
                                                sCodigoProduto, _
                                                sCodigo2, _
                                                sDescricao, _
                                                sTipo, _
                                                sOrigem, _
                                                sUnidadeMedida, _
                                                sGrupoItem, _
                                                sSubgrupo1, _
                                                sD1Subgrupo1, _
                                                sD2Subgrupo1, _
                                                sSubgrupo2, _
                                                sD1Subgrupo2, _
                                                sRevisao, _
                                                sSC, _
                                                sDET, _
                                                sMP, _
                                                sDimensao, _
                                                sUnidadeDimensao)

            oApplicationClass.Cells(iRegistro, 1) = sCodigoProduto
            oApplicationClass.Cells(iRegistro, 2) = sCodigo2
            oApplicationClass.Cells(iRegistro, 3) = sDescricao
            oApplicationClass.Cells(iRegistro, 4) = 1
            oApplicationClass.Cells(iRegistro, 5) = sUnidadeMedida
            oApplicationClass.Cells(iRegistro, 6) = dQuantidade
            oApplicationClass.Cells(iRegistro, 7) = dQuantidade * CDbl(sInputBox)
            oApplicationClass.Cells(iRegistro, 8) = sSC
            oApplicationClass.Cells(iRegistro, 9) = sDET
            oApplicationClass.Cells(iRegistro, 10) = sMP
            oApplicationClass.Cells(iRegistro, 11) = sDimensao
            oApplicationClass.Cells(iRegistro, 12) = sUnidadeDimensao

            oApplicationClass.Rows(iRegistro).Select()
            oApplicationClass.Selection.Interior.color = 5296274

            'Laço de repetição para imprimir os nós
            For Each oRow As GridEXRow In grdListagem.GetDataRows

                'Imprime recursivamente 
                ImprimirNO(oApplicationClass, oRow, 1, iRegistro, dQuantidade * CDbl(sInputBox))

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
                           ByRef oRow As GridEXRow, _
                           ByRef iNivel As Integer, _
                           ByRef iRegistro As Integer, _
                           ByRef dQuantidadeTotal As Double)

        Try

            'Incrementa o nivel
            iNivel += 1

            Dim iNivelInicial As Integer = iNivel

            'Incrementa a linha
            iRegistro += 1

            Dim iCodigoPai As Integer
            Dim iCodigoFIlho As Integer

            If iNivel = 2 Then
                iCodigoPai = oRow.Cells("codigo_item_pai").Value
                iCodigoFIlho = oRow.Cells("codigo_item").Value
            ElseIf iNivel = 3 Then
                iCodigoPai = oRow.Cells("codigo_item_pai2").Value
                iCodigoFIlho = oRow.Cells("codigo_item2").Value
            Else
                iCodigoPai = oRow.Cells("codigo_item_pai3").Value
                iCodigoFIlho = oRow.Cells("codigo_item3").Value
            End If

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
            Dim sSC As String
            Dim sDET As String
            Dim sMP As String
            Dim sDimensao As String
            Dim sUnidadeDimensao As String

            'Carrega os dados
            oClsCadProduto.LoadDadosExportarBOM(iCodigoPai, _
                                                iCodigoFIlho, _
                                                dQuantidade, _
                                                sCodigoProduto, _
                                                sCodigo2, _
                                                sDescricao, _
                                                sTipo, _
                                                sOrigem, _
                                                sUnidadeMedida, _
                                                sGrupoItem, _
                                                sSubgrupo1, _
                                                sD1Subgrupo1, _
                                                sD2Subgrupo1, _
                                                sSubgrupo2, _
                                                sD1Subgrupo2, _
                                                sRevisao, _
                                                sSC, _
                                                sDET, _
                                                sMP, _
                                                sDimensao, _
                                                sUnidadeDimensao)

            oApplicationClass.Cells(iRegistro, 1) = sCodigoProduto
            oApplicationClass.Cells(iRegistro, 2) = sCodigo2
            oApplicationClass.Cells(iRegistro, 3) = sDescricao
            oApplicationClass.Cells(iRegistro, 4) = 1
            oApplicationClass.Cells(iRegistro, 5) = sUnidadeMedida
            oApplicationClass.Cells(iRegistro, 6) = dQuantidade
            oApplicationClass.Cells(iRegistro, 7) = dQuantidadeTotal
            oApplicationClass.Cells(iRegistro, 8) = sSC
            oApplicationClass.Cells(iRegistro, 9) = sDET
            oApplicationClass.Cells(iRegistro, 10) = sMP
            oApplicationClass.Cells(iRegistro, 11) = sDimensao
            oApplicationClass.Cells(iRegistro, 12) = sUnidadeDimensao

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

            For Each oRowFilho As GridEXRow In oRow.GetChildRecords

                ImprimirNO(oApplicationClass, oRowFilho, iNivel, iRegistro, dQuantidade * dQuantidadeTotal)

                'Volta para o nivel anterior
                iNivel = iNivelInicial

            Next

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#End Region

    Private Sub btnPesquisarBOM_Click(sender As Object, e As EventArgs) Handles btnPesquisarBOM.Click

        Try

            If ValidaCampo(cboCodigoProduto, lblCodigoProduto) = False Then Exit Sub

            'Váriaveis - Formulário
            Dim oForm As New frmCadProdutoBOMPesquisar

            oForm.CodigoItem = cboCodigoProduto.SelectedValue
            oForm.CodigoProduto = cboCodigoProduto.Text
            oForm.ShowDialog(Me)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

End Class