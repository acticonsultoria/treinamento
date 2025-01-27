Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports CrystalDecisions.CrystalReports.Engine
Imports Janus.Windows.UI.Tab
Imports Janus.Windows.CalendarCombo
Imports System.IO
Imports System.Math
Imports System.Reflection
Imports System.Reflection.Assembly
Imports Microsoft.Office.Interop

Public Class usrVenInvoice

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsVenInvoice As New clsUsrVenInvoice
    Private iFormulario As Integer

#End Region

#Region "::: CONTROLES :::"

#Region "::: DADOS GERAIS :::"

    Private Sub usr_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.F3

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    Select Case sender.Name
                        Case "cboClienteFiltro" : Call btnProcurarClienteFiltro_Click(btnProcurarClienteFiltro, System.EventArgs.Empty)
                    End Select

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                Case Keys.Enter
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGrid() Else Control_Enter(sender)


            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub usrLoad(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        ConfigurarUserControl()

    End Sub

#End Region

#Region "::: INVOICE :::"

    Private Sub btnConfigurarGridPedido_Click(sender As Object, e As EventArgs) Handles btnConfigurarGridPedido.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdPedido
            oForm.NomeFormulario = iFormulario
            oForm.ShowDialog(Me)

            'Configura Grid
            ConfiguraGrid(grdPedido, iFormulario)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnAgruparGridPedido_Click(sender As Object, e As EventArgs) Handles btnAgruparGridPedido.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdPedido.GroupByBoxVisible = True Then
                'Oculta Grupo
                grdPedido.GroupByBoxVisible = False
            Else
                'Exibe Grupo
                grdPedido.GroupByBoxVisible = True
                grdPedido.HideColumnsWhenGrouped = InheritableBoolean.True
            End If

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnExcelGridPedido_Click(sender As Object, e As EventArgs) Handles btnExcelGridPedido.Click

        Try

            ExportExcel(grdPedido)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGrid_Click(sender As Object, e As EventArgs) Handles btnExcelGrid.Click

        Try

            ExportExcel(grdListagem)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnAgruparGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgrupaGrid.Click

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
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnConfigurarGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfiguraGrid.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdListagem
            oForm.NomeFormulario = iFormulario
            oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, iFormulario)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnProcurarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarCliente.Click

        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindParceiroNegocio"
            oForm.Titulo = Me.Parent.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar Parceiro de Negócio"

            'Seta Parametros
            iCodigoTipoParceiroNegocioFind = TipoParceiroNegocio.cliente
            oComboBoxFind = cboCliente

            oForm.ShowDialog(Me)

            'Seta Focu
            cboCliente.Focus()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnProcurarClienteFiltro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarClienteFiltro.Click

        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindParceiroNegocio"
            oForm.Titulo = Me.Parent.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar Parceiro de Negócio"

            'Seta Parametros
            iCodigoTipoParceiroNegocioFind = TipoParceiroNegocio.cliente
            oComboBoxFind = cboClienteFiltro

            oForm.ShowDialog(Me)

            'Seta Focu
            cboClienteFiltro.Focus()

        Catch ex As Exception
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

            Novo()

            'Alterna Aba        
            tabMain.TabPages.Remove(pagListagem)
            tabMain.TabPages.Add(pagDados)

            cboCliente.Focus()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnNovo1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo1.Click

        Try

            Novo()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click

        Try

            'Deleta Aba
            If TypeOf Me.Parent Is Form Then Me.Parent.Dispose() Else If TypeOf Me.Parent Is Panel Then Me.Parent.Controls.Remove(Me) Else frmMain.tabMain.TabPages.Remove(Me.Parent)
            'Fecha o Controle
            Me.Dispose()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            If Validacao() = False Then Exit Sub

            Salvar()

            btnImprimir.Enabled = VerificaDireito(iFormulario, gcPrint)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click

        Try

            If Validacao() = False Then Exit Sub

            Salvar()

            Imprimir(btnSalvar.Tag)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnVoltar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVoltar.Click

        Try

            LoadGrid()

            tabMain.TabPages.Remove(pagDados)
            tabMain.TabPages.Add(pagListagem)

            'Seta Focu
            txtNumeroInvoiceFiltro.Focus()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdListagem.RowDoubleClick

        Try

            'Verifica se a Coluna é Válida
            If IsNothing(grdListagem.CurrentColumn) Then Exit Sub

            Select Case grdListagem.CurrentColumn.Key

                Case "editar" : Editar()
                Case "imprimir" : Imprimir(grdListagem.CurrentRow.Cells.Item("codigo").Value)
                Case "excluir" : Delete()

            End Select

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grd_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdListagem.ColumnMoved, grdPedido.ColumnMoved

        Try

            'Atualiza Grid
            UpdateConfiguraGrid(sender, _
                                iFormulario)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grd_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdListagem.SizingColumn, _
                                                                                                                        grdPedido.SizingColumn

        Try

            'Atualiza Grid
            UpdateConfiguraGrid(sender.Name, _
                                iFormulario, _
                                e.Column.Key, _
                                e.ProposedWidth)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grd_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdListagem.GroupsChanging, _
                                                                                           grdPedido.GroupsChanging

        Try

            UpdateConfiguraGridGrupo(sender.Name, _
                                     iFormulario, _
                                     e.Group.Column.Key, _
                                     IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                     e.ProposedPosition)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnImportarPedido_Click(sender As Object, e As EventArgs) Handles btnImportarPedido.Click

        Try

            frmMain.errInfo.Clear()

            If ValidacaoImportacao() = False Then Exit Sub

            Dim oForm As New frmVenImportarPedidoInvoice
            oForm.CodigoInvoice = btnSalvar.Tag
            oForm.CodigoCliente = cboCliente.SelectedValue
            oForm.Cliente = cboCliente.Text.Trim
            oForm.CboCliente = cboCliente
            oForm.ShowDialog()

            If cboCliente.Enabled = False Then btnProcurarCliente.Enabled = False

            oClsVenInvoice.LoadGridInvoicePedido(grdPedido, _
                                                 btnSalvar.Tag)

            oClsVenInvoice.LoadDadosPedido(btnSalvar.Tag, _
                                           txtValorTotal, _
                                           txtPesoLiquido)
           
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdPedido_RowDoubleClick(sender As Object, e As RowActionEventArgs) Handles grdPedido.RowDoubleClick

        Try

            'Verifica se a Coluna é Válida
            If IsNothing(grdPedido.CurrentColumn) Then Exit Sub

            Select Case grdPedido.CurrentColumn.Key

                Case "excluir" : DeletePedido()

            End Select

        Catch ex As Exception
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
            AddKeyDown(Me, New DelegateKeyDown(AddressOf usr_KeyDown))
            AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Verifica Direito
            btnNovo.Enabled = VerificaDireito(iFormulario, gcInsert)
            btnSalvar.Enabled = VerificaDireito(iFormulario, gcInsert)
            btnExcelGrid.Enabled = VerificaDireito(iFormulario, gcInsert)

            LoadCombo(cboClienteFiltro, "sp_select_combo_cadastro_basico_cliente " & goUsuario.iEmpresa)
            LoadCombo(cboCliente, "sp_select_combo_cadastro_basico_cliente " & goUsuario.iEmpresa)

            'Configura DateTimer
            dtpDataInvoiceInicioFiltro.Value = DateAdd(DateInterval.Day, (DatePart(DateInterval.Day, Now.Date) - 1) * -1, Now.Date) : dtpDataInvoiceInicioFiltro.Checked = False
            dtpDataInvoiceTerminoFiltro.Value = Now.Date : dtpDataInvoiceTerminoFiltro.Checked = False

            'Seta Aba
            tabMain.TabPages.Remove(pagDados)

            'Configura Grid
            ConfiguraGrid(grdListagem, iFormulario)
            ConfiguraGrid(grdPedido, iFormulario)

            'Seta Focu
            txtNumeroInvoiceFiltro.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: INVOICE :::"

    Private Sub LoadGrid()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Carrega Controles
            oClsVenInvoice.LoadGrid(grdListagem, _
                                    txtNumeroInvoiceFiltro.Text.Trim, _
                                    IIf(dtpDataInvoiceInicioFiltro.Checked = False, "", dtpDataInvoiceInicioFiltro.Value), _
                                    IIf(dtpDataInvoiceTerminoFiltro.Checked = False, "", dtpDataInvoiceTerminoFiltro.Value), _
                                    IIf(cboClienteFiltro.SelectedIndex = -1, -1, cboClienteFiltro.SelectedValue), _
                                    txtPedidoVendaFiltro.Text.Trim)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Function ValidacaoImportacao() As Boolean

        Try

            If ValidaCampo(cboCliente, lblCliente) = False Then Return False

            'Verifica se o registro da invoice já existe
            If IsNumeric(btnSalvar.Tag) = False Then

                oClsVenInvoice.InsertGerarCodigo(cboCliente.SelectedValue, _
                                                 txtNumeroInvoice)

                btnSalvar.Tag = oClsVenInvoice.Codigo

            End If

            Return True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub Editar()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Verifica se o usuário tem direito de alterar algum registro
            If VerificaDireito(iFormulario, gcUpdate) = True Then

                Novo()

                btnSalvar.Tag = grdListagem.CurrentRow.Cells("codigo").Value

                oClsVenInvoice.LoadDados(btnSalvar.Tag, _
                                         txtNumeroInvoice, _
                                         dtpData, _
                                         cboCliente, _
                                         txtImportadora, _
                                         txtPagadora, _
                                         txtReceptorMercadoria, _
                                         txtObservacao, _
                                         txtMeioTransporte, _
                                         txtEmbarque, _
                                         txtDesembarque, _
                                         txtIncoterm, _
                                         txtCondicaoPagamento, _
                                         txtMoeda, _
                                         txtPaisOrigem, _
                                         txtPesoLiquido, _
                                         txtPesoGrosso, _
                                         txtVolume, _
                                         txtValorTotal, _
                                         txtValorFrete, _
                                         txtValorSeguro, _
                                         txtValorFinal, _
                                         txtBanco, _
                                         txtSwiftCodeBanco, _
                                         txtNumeroConta, _
                                         txtFavorecido, _
                                         txtSwiftCode, _
                                         txtBranchNumber, _
                                         txtCodigoIBAN)

                oClsVenInvoice.LoadGridInvoicePedido(grdPedido, _
                                                     btnSalvar.Tag)

                'oClsVenInvoice.LoadDadosPedido(btnSalvar.Tag, _
                '                               txtValorTotal, _
                '                               txtPesoLiquido)

                cboCliente.Enabled = False
                btnProcurarCliente.Enabled = False

                tabMain.TabPages.Remove(pagListagem)
                tabMain.TabPages.Add(pagDados)

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

    Private Sub Novo()

        Try

            'Limpa Erro 
            frmMain.errInfo.Clear()

            grdPedido.DataSource = Nothing
            LimparCamposGroupBox(grpInformacoes)
            LimparCamposGroupBox(grpDadosInvoice)
            LimparCamposGroupBox(grpPayment)
            LimparCamposGroupBox(grpTotais)

            cboCliente.Enabled = True
            btnProcurarCliente.Enabled = True
            btnSalvar.Tag = ""

            tabDados.SelectedTab = pagPedido

            cboCliente.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Salvar()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            oClsVenInvoice.Update(btnSalvar.Tag, _
                                  dtpData.Value, _
                                  txtImportadora.Text, _
                                  txtPagadora.Text, _
                                  txtReceptorMercadoria.Text, _
                                  txtMeioTransporte.Text, _
                                  txtEmbarque.Text, _
                                  txtDesembarque.Text, _
                                  txtIncoterm.Text, _
                                  txtCondicaoPagamento.Text, _
                                  txtMoeda.Text, _
                                  txtPaisOrigem.Text, _
                                  txtValorTotal.Text, _
                                  txtValorFrete.Text, _
                                  txtValorSeguro.Text, _
                                  txtValorFinal.Text, _
                                  txtPesoLiquido.Text, _
                                  txtPesoGrosso.Text, _
                                  txtVolume.Text, _
                                  txtObservacao.Text, _
                                  txtBanco.Text.Trim, _
                                  txtSwiftCodeBanco.Text.Trim, _
                                  txtNumeroConta.Text.Trim, _
                                  txtFavorecido.Text.Trim, _
                                  txtSwiftCode.Text.Trim, _
                                  txtBranchNumber.Text.Trim, _
                                  txtCodigoIBAN.Text.Trim)

            frmMain.Informacao(Mensagem.RegistroSalvo)

            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Delete()

        Try

            'Verifica se o Usuário Deseja Excluir os Registros Selecionados
            If MsgBox("Deseja excluir permanentemente este registro?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                'Seta Cursor do Mouse
                Cursor.Current = Cursors.WaitCursor

                'Exclui Registro
                oClsVenInvoice.Delete(grdListagem.CurrentRow.Cells("codigo").Value)

                LoadGrid()

                'Informa o Usuário sobre o Sucesso da Operação
                frmMain.Informacao(Mensagem.RegistroExcluido)

                'Seta Cursor do Mouse
                Cursor.Current = Cursors.Default

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Imprimir(ByVal lCodigo As Long)

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Váriavel - Relatório
            Dim sReport As String = ""

            'Redimenciona Vetor
            ReDim goCrystalReport.sReportParameter(1)
            'Seta Parametros
            goCrystalReport.sReportParameter(0).sParamenter = "@codigo"
            goCrystalReport.sReportParameter(0).sValue = lCodigo
            goCrystalReport.sReportParameter(1).sParamenter = "@codigo_empresa"
            goCrystalReport.sReportParameter(1).sValue = goUsuario.iEmpresa
            goCrystalReport.sReport = goCrystalReport.sPath & "rptPackingListItem.rpt"

            Dim oReport As New usrReport
            oReport.Dock = DockStyle.Fill

            'Abre Relatório
            frmMain.LoadPageReport("rptPackingListItem", "Invoice", oReport)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function Validacao() As Boolean

        Try

            If ValidaCampo(cboCliente, lblCliente) = False Then
                Return False
            End If

            If IsNumeric(btnSalvar.Tag) = False Then

                oClsVenInvoice.InsertGerarCodigo(cboCliente.SelectedValue, _
                                                 txtNumeroInvoice)

                btnSalvar.Tag = oClsVenInvoice.Codigo

            End If

            Return True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub ValorTotal() Handles txtValorTotal.ValueChanged, _
                                     txtValorFrete.ValueChanged, _
                                     txtValorSeguro.ValueChanged

        Try

            txtValorFinal.Value = txtValorTotal.Value + txtValorFrete.Value + txtValorSeguro.Value

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub DeletePedido()

        Try

            'Verifica se o Usuário Deseja Excluir os Registros Selecionados
            If MsgBox("Deseja excluir permanentemente este registro?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                'Seta Cursor do Mouse
                Cursor.Current = Cursors.WaitCursor

                'Exclui Registro
                oClsVenInvoice.DeletePedido(lCodigoInvoice:=btnSalvar.Tag, _
                                            lCodigoPedido:=grdPedido.CurrentRow.Cells("codigo_pedido").Value, _
                                            iCodigoPedidoItem:=grdPedido.CurrentRow.Cells("codigo_pedido_item").Value)

                oClsVenInvoice.LoadGridInvoicePedido(oGrid:=grdPedido, _
                                                     lCodigoInvoice:=btnSalvar.Tag)

                oClsVenInvoice.LoadDadosPedido(btnSalvar.Tag, _
                                               txtValorTotal, _
                                               txtPesoLiquido)

                'Informa o Usuário sobre o Sucesso da Operação
                frmMain.Informacao(Mensagem.RegistroExcluido)

                'Seta Cursor do Mouse
                Cursor.Current = Cursors.Default

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#End Region

End Class


