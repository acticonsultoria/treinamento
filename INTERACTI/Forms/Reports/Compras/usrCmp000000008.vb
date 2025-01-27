Imports Janus.Windows.GridEX

Public Class usrCmp000000008

    'Variáveis da Classe
    Private oClsCmp000000008 As New clsUsrCmp000000008

#Region "::: CONTROLES :::"

    Private Sub usrCmp000000008_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

    Private Sub usrCmp000000008_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter 
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGrid Else Control_Enter(sender)
                    
                Case Keys.F5
                    Select Case sender.Name
                        Case "cboGrupoItemFiltro" : Call LoadCombo(cboStatusFiltro, "sp_select_combo_cadastro_basico_grupo_item " & goUsuario.iEmpresa, True)
                    End Select


            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnAgruparGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

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

    Private Sub btnConfigurarGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdListagem
            oForm.NomeFormulario = Formulario.RelatorioCMP000000008
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.RelatorioCMP000000008)

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

    Private Sub btnVisualizarImpressao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVisualizarImpressao.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Visualizar Impressão
            Call VisualizarImpressao()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcel.Click

        Try

            'Exporta para Excel
            Call ExportExcel(grdListagem)

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

    Private Sub cboUFFiltro_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboUFFiltro.SelectedIndexChanged

        Try

            'Verifica se foi selecionado algum Registro
            If cboUFFiltro.SelectedIndex = -1 Then
                cboMunicipioFiltro.DataSource = Nothing
                cboMunicipioFiltro.Text = ""
            Else
                Call LoadCombo(cboMunicipioFiltro, "sp_select_combo_static_municipio '" & cboUFFiltro.SelectedValue & "'")
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs)

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem, _
                                     Formulario.RelatorioCMP000000008)

            'Carrega Combo
            Call LoadComboColunasGrid(cboCongelarColuna, grdListagem)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs)

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem.Name, _
                                     Formulario.RelatorioCMP000000008, _
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
                                          Formulario.RelatorioCMP000000008, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdListagem.RowDoubleClick

        Try

            'Verifica se a Coluna é Válida
            If IsNothing(grdListagem.CurrentColumn) Then Exit Sub

            'Verifica o Tipo de Operação
            Select Case grdListagem.CurrentColumn.Key

                Case "visualizar"
                    If IsDBNull(grdListagem.CurrentRow.Cells("arquivo").Value) = False Then
                        Call VisualizarDocumentoBD(grdListagem.CurrentRow.Cells("arquivo").Value, grdListagem.CurrentRow.Cells("extensao").Value)
                    Else
                        frmMain.Informacao(Mensagem.OperacaoNaoRealizada, "Não foi inserido nenhum Arquivo.")
                    End If

            End Select

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

            'Adiciona KeyUP
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrCmp000000008_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Carrega ComboBox
            Call LoadComboColunasGrid(cboCongelarColuna, grdListagem)
            Call LoadCombo(cboClassificacaoFiltro, "sp_select_combo_cadastro_basico_fornecedor_classificacao " & goUsuario.iEmpresa, False)
            Call LoadCombo(cboUFFiltro, "sp_select_combo_static_estado")
            'Carraga Combo - Status
            cboStatusFiltro.Items.Clear()
            cboStatusFiltro.Items.Add("CERTIFICADO EM DIA", 1)
            cboStatusFiltro.Items.Add("CERTIFICADO VENCIDO", 2)            

            'Verifica Direito
            btnExcel.Enabled = VerificaDireito(Formulario.RelatorioCMP000000008, gcPrint)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.RelatorioCMP000000008)

            'Seta Focu
            cboClassificacaoFiltro.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub LoadGrid()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Parametros
            oClsCmp000000008.LoadGrid(grdListagem, _
                                      IIf(cboClassificacaoFiltro.SelectedIndex = -1, "", cboClassificacaoFiltro.SelectedValue), _
                                      IIf(cboUFFiltro.SelectedIndex = -1, "", cboUFFiltro.SelectedValue), _
                                      IIf(cboMunicipioFiltro.SelectedIndex = -1, -1, cboMunicipioFiltro.SelectedValue), _
                                      IIf(cboStatusFiltro.SelectedIndex = -1, -1, cboStatusFiltro.SelectedValue), _
                                      txtNumeroDiasVencimentoFiltro.Value)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub VisualizarImpressao()

        Try

            'Redimensiona Vetor
            ReDim goCrystalReport.sReportParameter(6)

            'Relatório
            goCrystalReport.sReport = goCrystalReport.sPath & "CMP000000008.rpt"

            'Seta Paramentro - Nome
            goCrystalReport.sReportParameter(0).sParamenter = "usuario"
            goCrystalReport.sReportParameter(0).sValue = goUsuario.sNome
            'Seta Paramentro - Empresa
            goCrystalReport.sReportParameter(1).sParamenter = "@codigo_empresa"
            goCrystalReport.sReportParameter(1).sValue = goUsuario.iEmpresa
            'Seta Paramentro - Classificação
            goCrystalReport.sReportParameter(2).sParamenter = "@classificacao"
            goCrystalReport.sReportParameter(2).sValue = IIf(cboClassificacaoFiltro.SelectedIndex = -1, "", cboClassificacaoFiltro.SelectedValue)
            'Seta Paramentro - UF
            goCrystalReport.sReportParameter(3).sParamenter = "@uf"
            goCrystalReport.sReportParameter(3).sValue = IIf(cboUFFiltro.SelectedIndex = -1, "", cboUFFiltro.SelectedValue)
            'Seta Paramentro - Código Município
            goCrystalReport.sReportParameter(4).sParamenter = "@codigo_municipio"
            goCrystalReport.sReportParameter(4).sValue = IIf(cboMunicipioFiltro.SelectedIndex = -1, -1, cboMunicipioFiltro.SelectedValue)
            'Seta Paramentro - Status
            goCrystalReport.sReportParameter(5).sParamenter = "@status"
            goCrystalReport.sReportParameter(5).sValue = IIf(cboStatusFiltro.SelectedIndex = -1, -1, cboStatusFiltro.SelectedValue)
            'Seta Paramentro - Nº Dias Vencimento
            goCrystalReport.sReportParameter(6).sParamenter = "@numero_dias_vencimento"
            goCrystalReport.sReportParameter(6).sValue = IIf(txtNumeroDiasVencimentoFiltro.Value = 0, "NULL", txtNumeroDiasVencimentoFiltro.Value)

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
