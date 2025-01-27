Imports Janus.Windows.GridEX

Public Class usrIndCompras2

#Region "::: VÁRIAVEIS :::"

    'Classe
    Private oClsIndCompras2 As New clsUsrIndCompras2

#End Region

#Region "::: CONTROLES :::"

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
            oForm.NomeFormulario = Formulario.ComprasIndicador2
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.ComprasIndicador2)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelDados_Click(sender As Object, e As EventArgs) Handles btnExcelDados.Click

        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdDados)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnAgruparGridDados_Click(sender As Object, e As EventArgs) Handles btnAgruparGridDados.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdDados.GroupByBoxVisible = True Then

                'Oculta Grupo
                grdDados.GroupByBoxVisible = False

            Else

                'Exibe Grupo
                grdDados.GroupByBoxVisible = True
                grdDados.HideColumnsWhenGrouped = InheritableBoolean.True

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnConfigurarGridDados_Click(sender As Object, e As EventArgs) Handles btnConfigurarGridDados.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdDados
            oForm.NomeFormulario = Formulario.ComprasIndicador2
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdDados, Formulario.ComprasIndicador2)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub


    Private Sub usrIndFat000000001_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown

        Try

            Select Case e.KeyCode

                Case Keys.Enter
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call btnFiltrar_Click(btnFiltrar, System.EventArgs.Empty) Else Control_Enter(sender)

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
                                     Formulario.ComprasIndicador2, _
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
                                     Formulario.ComprasIndicador2)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub usrIndFat000000001_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

    Private Sub btnFiltrar_Click(sender As Object, e As EventArgs) Handles btnFiltrar.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Carrega Dados da Grid
            Call LoadGrid()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnFiltrarDados_Click(sender As Object, e As EventArgs) Handles btnFiltrarDados.Click

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            Call oClsIndCompras2.LoadGridDados(grdDados, _
                                               txtFornecedorDados.Tag, _
                                               dtpDataInicioDados.Value, _
                                               dtpDataTerminoDados.Value)

            Call oClsIndCompras2.LoadGraficoPO(chrGraficoOnTimePO, _
                                               chrGraficoOntimeMensal, _
                                               chrGraficoIAF, _
                                               dtpDataInicioDados.Value, _
                                               dtpDataTerminoDados.Value, _
                                               txtToleranciaDados.Value, _
                                               txtFornecedorDados.Tag, _
                                               txtMetaDados.Value)


            Cursor.Current = Cursors.Default


        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnSair_Click_1(sender As Object, e As EventArgs) Handles btnSair.Click

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

    Private Sub grdListagem_RowDoubleClick(sender As Object, e As RowActionEventArgs) Handles grdListagem.RowDoubleClick

        Try

            Select Case grdListagem.CurrentColumn.Key

                Case "visualizar" : Call VisualizarGraficoGrid(grdListagem.CurrentRow.Cells("codigo_fornecedor").Value, _
                                                               grdListagem.CurrentRow.Cells("fornecedor").Value)

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnVoltar_Click(sender As Object, e As EventArgs) Handles btnVoltar.Click

        Try

            Call LoadGrid()

            'Alterna Aba
            tabMain.TabPages.Remove(pagDados)
            tabMain.TabPages.Add(pagListagem)

        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnVisualizarGrafico_Click(sender As Object, e As EventArgs) Handles btnVisualizarGrafico.Click

        Try

            Call VisualizarGrafico()

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
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrIndFat000000001_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            Call ConfiguraGrid(grdListagem, Formulario.ComprasIndicador2)
            Call ConfiguraGrid(grdDados, Formulario.ComprasIndicador2)

            'Configura DateTimePicker
            dtpDataInicioFiltro.Value = New Date(Year(Now), 1, 1) : dtpDataInicioFiltro.Checked = False
            dtpDataTerminoFiltro.Value = Now.Date : dtpDataTerminoFiltro.Checked = False

            Call LoadCombo(cboGrupoTecnologiaFiltro, "sp_select_combo_static_grupo_tecnologia")
            Call LoadCombo(cboFornecedorFiltro, "sp_select_combo_cadastro_basico_parceiro_negocio " & goUsuario.iEmpresa)

            cboGrupoTecnologiaFiltro.CheckAll()

            'Desabilita Aba
            tabMain.TabPages.Remove(pagDados)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub LoadGrid()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            Dim sFornecedor As String = ""
            Dim sGrupoTecnologia As String = ""

            If cboFornecedorFiltro.SelectionLength > 0 Then
                For i = 0 To UBound(cboFornecedorFiltro.CheckedValues)
                    sFornecedor &= IIf(sFornecedor = "", "", ",") & cboFornecedorFiltro.CheckedValues(i).ToString
                Next
            End If

            If cboGrupoTecnologiaFiltro.SelectionLength > 0 Then
                For i = 0 To UBound(cboGrupoTecnologiaFiltro.CheckedValues)
                    sGrupoTecnologia &= IIf(sGrupoTecnologia = "", "", ",") & cboGrupoTecnologiaFiltro.CheckedValues(i).ToString
                Next
            End If

            'Carrega Grid
            Call oClsIndCompras2.LoadGrid(grdListagem, _
                                          IIf(dtpDataInicioFiltro.Enabled = True, dtpDataInicioFiltro.Value, ""), _
                                          IIf(dtpDataTerminoFiltro.Enabled = True, dtpDataTerminoFiltro.Value, ""), _
                                          sGrupoTecnologia, _
                                          sFornecedor, _
                                          txtToleranciaFiltro.Value)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub VisualizarGraficoGrid(ByVal sCodigoFornecedor As String, _
                                      ByVal sFornecedor As String)

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            dtpDataInicioDados.Value = dtpDataInicioFiltro.Value
            dtpDataTerminoDados.Value = dtpDataTerminoFiltro.Value
            txtToleranciaDados.Value = txtToleranciaFiltro.Value
            txtMetaDados.Value = txtMetaFiltro.Value
            txtFornecedorDados.Text = sFornecedor
            txtFornecedorDados.Tag = CInt(sCodigoFornecedor)

            'Carrega Grid de Item
            Call oClsIndCompras2.LoadGridDados(grdDados, _
                                               sCodigoFornecedor, _
                                               dtpDataInicioFiltro.Value, _
                                               dtpDataTerminoFiltro.Value)

            Call oClsIndCompras2.LoadGraficoPO(chrGraficoOnTimePO, _
                                               chrGraficoOntimeMensal, _
                                               chrGraficoIAF, _
                                               dtpDataInicioFiltro.Value, _
                                               dtpDataTerminoFiltro.Value, _
                                               txtToleranciaFiltro.Value, _
                                               txtFornecedorDados.Tag, _
                                               txtMetaFiltro.Value)


            'Alterna Aba
            tabMain.TabPages.Remove(pagListagem)
            tabMain.TabPages.Add(pagDados)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub VisualizarGrafico()

        Try

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdListagem) = True Then

                'Seta Cursor do Mouse
                Cursor.Current = Cursors.WaitCursor

                Dim sCodigoFornecedor As String

                For i = 0 To UBound(grdListagem.GetCheckedRows)
                    sCodigoFornecedor &= IIf(sCodigoFornecedor = "", "", ",") & grdListagem.GetCheckedRows(i).Cells("codigo_fornecedor").Value
                Next

                txtFornecedorDados.Tag = sCodigoFornecedor
                dtpDataInicioDados.Value = dtpDataInicioFiltro.Value
                dtpDataTerminoDados.Value = dtpDataTerminoFiltro.Value
                txtToleranciaDados.Value = txtToleranciaFiltro.Value
                txtMetaDados.Value = txtMetaFiltro.Value

                'Carrega Grid de Item
                Call oClsIndCompras2.LoadGridDados(grdDados, _
                                                   sCodigoFornecedor, _
                                                   dtpDataInicioFiltro.Value, _
                                                   dtpDataTerminoFiltro.Value)

                Call oClsIndCompras2.LoadGraficoPO(chrGraficoOnTimePO, _
                                                   chrGraficoOntimeMensal, _
                                                   chrGraficoIAF, _
                                                   dtpDataInicioFiltro.Value, _
                                                   dtpDataTerminoFiltro.Value, _
                                                   txtToleranciaFiltro.Value, _
                                                   sCodigoFornecedor, _
                                                   txtMetaFiltro.Value)

                'Alterna Aba
                tabMain.TabPages.Remove(pagListagem)
                tabMain.TabPages.Add(pagDados)

                'Seta Cursor do Mouse
                Cursor.Current = Cursors.Default

            Else
                'Informa o Usuário da Necessidade de Selecionar um ou mai Registro
                frmMain.Informacao(Mensagem.ValidacaoSelecionar)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class
