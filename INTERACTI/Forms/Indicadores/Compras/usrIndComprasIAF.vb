Imports Janus.Windows.GridEX
Imports System.IO
Imports System.Drawing.Imaging

Public Class usrIndComprasIAF

#Region "::: VÁRIAVEIS :::"

    'Classe
    Private oClsUsrIndComprasIAF As New clsUsrIndComprasIAF

#End Region

#Region "::: CONTROLES :::"

    Private Sub cboCategoriaIAF_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCategoriaIAF.SelectedIndexChanged

        Try

            If cboCategoriaIAF.SelectedIndex <> -1 Then

                cboFornecedorFiltro.Text = ""
                cboFornecedorFiltro.SelectedIndex = -1

                Call LoadCombo(cboFornecedorFiltro, "sp_select_combo_cadastro_basico_parceiro_negocio_categoria " & cboCategoriaIAF.SelectedValue & "," & goUsuario.iEmpresa)

            End If

        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub usr_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown

        Try

            Select Case e.KeyCode

                Case Keys.Enter

                    If InStr(sender.name, "Placar", CompareMethod.Text) > 0 Then

                        btnFiltrarPlacar_Click(btnFiltrarPlacar, System.EventArgs.Empty)

                    ElseIf InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then

                        btnFiltrar_Click(btnFiltrar, System.EventArgs.Empty)

                    Else
                        Control_Enter(sender)
                    End If

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdListagem.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem.Name, _
                                     Formulario.ComprasIndicadorIAF, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdListagem.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem, _
                                     Formulario.ComprasIndicadorIAF)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagemMensal_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdListagemMensal.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagemMensal.Name, _
                                     Formulario.ComprasIndicadorIAF, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagemMensal_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdListagemMensal.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagemMensal, _
                                     Formulario.ComprasIndicadorIAF)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub usr_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ConfigurarUserControl()

    End Sub

    Private Sub btnFiltrar_Click(sender As Object, e As EventArgs) Handles btnFiltrar.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            If Validacao() = False Then Exit Sub

            'Carrega Dados da Grid
            LoadGrid()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnSair_Click_1(sender As Object, e As EventArgs) Handles btnSair.Click, _
                                                                          btnSairPlacar.Click

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

    Private Sub btnVoltar_Click(sender As Object, e As EventArgs) Handles btnVoltar.Click

        Try

            Call LoadGrid()

            'Alterna Aba
            tabMain.TabPages.Add(pagListagem)
            tabMain.TabPages.Add(pagPlacar)
            tabMain.TabPages.Remove(pagDados)

            tabMain.SelectedTab = pagListagem

        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnVisualizarGrafico_Click(sender As Object, e As EventArgs) Handles btnVisualizarGrafico.Click

        Try

            VisualizarGrafico()

        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnFiltrarPlacar_Click(sender As Object, e As EventArgs) Handles btnFiltrarPlacar.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            If ValidacaoPlacar() = False Then Exit Sub

            LoadChartPlacar()

        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Name)
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

    Private Sub btnAgruparGrid_Click(sender As Object, e As EventArgs) Handles btnAgruparGrid.Click

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

    Private Sub btnConfigurarGrid_Click(sender As Object, e As EventArgs) Handles btnConfigurarGrid.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdListagem
            oForm.NomeFormulario = Formulario.ComprasIndicadorIAF
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.ComprasIndicadorIAF)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGridMensal_Click(sender As Object, e As EventArgs) Handles btnExcelGridMensal.Click

        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdListagemMensal)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnAgruparGridMensal_Click(sender As Object, e As EventArgs) Handles btnAgruparGridMensal.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdListagemMensal.GroupByBoxVisible = True Then

                'Oculta Grupo
                grdListagemMensal.GroupByBoxVisible = False

            Else

                'Exibe Grupo
                grdListagemMensal.GroupByBoxVisible = True
                grdListagemMensal.HideColumnsWhenGrouped = InheritableBoolean.True

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnConfigurarGridMensal_Click(sender As Object, e As EventArgs) Handles btnConfigurarGridMensal.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdListagemMensal
            oForm.NomeFormulario = Formulario.ComprasIndicadorIAF
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagemMensal, Formulario.ComprasIndicadorIAF)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnProcurarFornecedor_Click(sender As Object, e As EventArgs) Handles btnProcurarFornecedor.Click

        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindParceiroNegocio"
            oForm.Titulo = Me.Parent.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar Parceiro de Negócio"

            'Seta Parametros
            iCodigoTipoParceiroNegocioFind = TipoParceiroNegocio.fornecedor
            oComboBoxFind = cboFornecedorFiltro

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            cboFornecedorFiltro.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click

        Try

            Call Imprimir()

        Catch ex As Exception
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
            AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            AddKeyDown(Me, New DelegateKeyDown(AddressOf usr_KeyDown))
            AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            ConfiguraGrid(grdListagem, Formulario.ComprasIndicadorIAF)
            ConfiguraGrid(grdListagemMensal, Formulario.ComprasIndicadorIAF)

            'Configura DateTimePicker
            LoadComboAno(cboAnoFiltro, 2019, 5)
            LoadComboMes(cboMesFiltro)
            LoadComboAno(cboAnoPlacarFiltro, 2019, 5)
            LoadComboMes(cboMesPlacarFiltro)

            LoadCombo(cboCategoriaPlacarFiltro, "sp_select_combo_static_categoria_parceiro_negocio", False)
            LoadCombo(cboCategoriaIAF, "sp_select_combo_static_categoria_parceiro_negocio", False)
            LoadCombo(cboStatusPlacarFiltro, "sp_select_combo_static_status_iaf", False)

            'Desabilita Aba
            tabMain.TabPages.Remove(pagDados)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Function Validacao() As Boolean

        Try

            If ValidaCampo(cboAnoFiltro, lblAno) = False Then Return False
            If ValidaCampo(cboMesFiltro, lblMes) = False Then Return False
            If ValidaCampo(cboFornecedorFiltro, lblFornecedor) = False Then Return False

            Return True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Function ValidacaoPlacar() As Boolean

        Try

            ValidacaoPlacar = False

            If ValidaCampo(cboAnoPlacarFiltro, lblAnoPlacarFiltro) = False Then
                Exit Function
            End If

            If ValidaCampo(cboMesPlacarFiltro, lblMesPlacarFiltro) = False Then
                Exit Function
            End If

            If ValidaCampo(cboCategoriaPlacarFiltro, lblCategoriaFiltro) = False Then
                Exit Function
            End If

            ValidacaoPlacar = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub LoadGrid()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Carrega Grid
            oClsUsrIndComprasIAF.LoadGrid(grdListagem, _
                                          grdListagemMensal, _
                                          cboAnoFiltro.SelectedValue, _
                                          cboMesFiltro.SelectedValue, _
                                          cboFornecedorFiltro.SelectedValue)


            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub LoadChartPlacar()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            Dim sData As String = cboMesPlacarFiltro.Text & "/" & cboAnoPlacarFiltro.Text.Substring(2, 2)

            'Carrega Grid
            oClsUsrIndComprasIAF.LoadChartPlacar(chrIAFPlacar, _
                                                 cboAnoPlacarFiltro.SelectedValue, _
                                                 cboMesPlacarFiltro.SelectedValue, _
                                                 cboCategoriaPlacarFiltro.SelectedValue, _
                                                 sData, _
                                                 IIf(cboStatusPlacarFiltro.SelectedIndex = -1, "", cboStatusPlacarFiltro.SelectedValue))

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub VisualizarGrafico()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            Call oClsUsrIndComprasIAF.LoadGrafico(chrIAF, _
                                                  cboAnoFiltro.SelectedValue, _
                                                  cboMesFiltro.SelectedValue, _
                                                  cboFornecedorFiltro.SelectedValue, _
                                                  cboFornecedorFiltro.Text)

            'Alterna Aba
            tabMain.TabPages.Remove(pagPlacar)
            tabMain.TabPages.Remove(pagListagem)
            tabMain.TabPages.Add(pagDados)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Imprimir()

        Try

            'Seta cursor do mouse
            Cursor.Current = Cursors.WaitCursor

            'Carrega o gráfico
            Call oClsUsrIndComprasIAF.LoadGrafico(chrIAF, _
                                                  cboAnoFiltro.SelectedValue, _
                                                  cboMesFiltro.SelectedValue, _
                                                  cboFornecedorFiltro.SelectedValue, _
                                                  cboFornecedorFiltro.Text)

            'Cria o caminho
            Dim sArquivo As String = "\\Serverbd\SENG\IAF\IAF_" & cboFornecedorFiltro.Text & "_" & Replace(Replace(CStr(DateTime.Now), "/", "_"), ":", "_") & ".png"

            'Salva a imagem do gráfico
            chrIAF.SaveAsImage(sArquivo, Dundas.Charting.WinControl.ChartImageFormat.Png)

            'Carrega a imagem salva
            Dim oImage As Image = Image.FromFile(sArquivo)

            'Cria o picturebox
            Dim picGrafico As New PictureBox

            'Seta o image
            picGrafico.Image = oImage

            'Insere no banco de dados
            oClsUsrIndComprasIAF.InsertGrafico(picGrafico, _
                                               cboFornecedorFiltro.Text, _
                                               cboAnoFiltro.SelectedValue, _
                                               cboMesFiltro.SelectedValue)

            'Redimenciona Vetor
            ReDim goCrystalReport.sReportParameter(0)
            'Seta Parametros
            goCrystalReport.sReportParameter(0).sParamenter = "@codigo_empresa"
            goCrystalReport.sReportParameter(0).sValue = goUsuario.iEmpresa
            goCrystalReport.sReport = goCrystalReport.sPath & "rptIAF.rpt"

            Dim oReport As New usrReport
            oReport.Dock = DockStyle.Fill

            'Abre Relatório
            frmMain.LoadPageReport("IAF", "Índice de Atendimento do Fornecedor", oReport)

            'Seta cursor do mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class
