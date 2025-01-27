Imports System.Reflection
Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports System.Reflection.Assembly

Public Class usrPrdPlanejamentoLegado

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsPrdPlanejamentoLegado As New clsUsrPrdPlanejamentoLegado
    Private iFormulario As Integer

#End Region

#Region "::: CONTROLES :::"

    Private Sub usr_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGrid() Else Control_Enter(sender)


            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub usr_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

    Private Sub grd_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdAnalitico.ColumnMoved,
                                                                                                                       grdProcesso.ColumnMoved,
                                                                                                                       grdListagem.ColumnMoved,
                                                                                                                       grdMaquinaAtual.ColumnMoved,
                                                                                                                       grdFuncionarioAtual.ColumnMoved,
                                                                                                                       grdApontamento.ColumnMoved
        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(sender,
                                    iFormulario)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grd_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdAnalitico.SizingColumn,
                                                                                                                        grdProcesso.SizingColumn,
                                                                                                                        grdListagem.SizingColumn,
                                                                                                                        grdMaquinaAtual.SizingColumn,
                                                                                                                        grdFuncionarioAtual.SizingColumn,
                                                                                                                        grdApontamento.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(sender.Name,
                                   iFormulario,
                                    e.Column.Key,
                                    e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub
    Private Sub btnFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltrar.Click

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

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            LoadGridMaquinaAtual()
            LoadGridFuncionarioAtual()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

   
    Private Sub LoadGridApontamento() Handles cboFuncionario.SelectedValueChanged, cboMaquina.SelectedValueChanged, dtpDataInicioApontamento.LostFocus, dtpDataTerminoApontamento.LostFocus
        Try
            oClsPrdPlanejamentoLegado.LoadGridApontamento(grdApontamento, _
                                                                     IIf(cboMaquina.SelectedIndex = -1, -1, cboMaquina.SelectedValue), _
                                                                     IIf(cboFuncionario.SelectedIndex = -1, -1, cboFuncionario.SelectedValue), _
                                                                     IIf(dtpDataInicioApontamento.Checked = True, dtpDataInicioApontamento.Value, ""), _
                                                                     IIf(dtpDataTerminoApontamento.Checked = True, dtpDataTerminoApontamento.Value, ""))

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub


    Private Sub grid_RowDoubleClick(sender As Object, e As RowActionEventArgs) Handles grdAnalitico.RowDoubleClick,
                                                                                       grdProcesso.RowDoubleClick,
                                                                                       grdMaquinaAtual.RowDoubleClick,
                                                                                       grdListagem.RowDoubleClick,
                                                                                       grdFuncionarioAtual.RowDoubleClick,
                                                                                       grdApontamento.RowDoubleClick
        Try
            'Verifica o Tipo de Registro
            If IsNothing(sender.CurrentColumn) Then Exit Sub

            Select Case sender.CurrentColumn.Key

                Case "ordem_producao" : EditarOrdemProducao(sender)
                Case "recalcular_data_producao" : RecalcularDataProducao(sender.CurrentRow.Cells.Item("codigo_ordem_producao").Value)

            End Select

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub


#End Region

#Region "::: FUNCTION / SUB :::"


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


            'Seta Controle
            dtpDataNecessidadeInicioFiltro.Value = Now.Date : dtpDataNecessidadeInicioFiltro.Checked = False
            dtpDataNecessidadeTerminoFiltro.Value = Now.Date : dtpDataNecessidadeTerminoFiltro.Checked = False

            dtpDataInicioApontamento.Value = Now.Date : dtpDataInicioApontamento.Checked = True
            dtpDataTerminoApontamento.Value = Now.Date : dtpDataTerminoApontamento.Checked = True

            Call LoadCombo(cboMaquina, "sp_select_combo_cadastro_basico_maquina -1," & goUsuario.iEmpresa)
            Call LoadCombo(cboFuncionario, "sp_select_combo_cadastro_basico_funcionario " & goUsuario.iEmpresa)
            Call LoadCombo(cboCliente, "sp_select_combo_cadastro_basico_cliente_planejamento_legado " & goUsuario.iEmpresa, False)
            Call LoadCombo(cboStatusFiltro, "sp_select_combo_static_status_ordem_producao 1")
            'cboStatusFiltro.CheckAll()


            Timer1.Interval = 60000
            Timer1.Enabled = True

            'Configura Grid
            Call ConfiguraGrid(grdAnalitico, iFormulario)
            Call ConfiguraGrid(grdListagem, iFormulario)
            Call ConfiguraGrid(grdProcesso, iFormulario)
            Call ConfiguraGrid(grdMaquinaAtual, iFormulario)
            Call ConfiguraGrid(grdFuncionarioAtual, iFormulario)
            Call ConfiguraGrid(grdApontamento, iFormulario)

            'Configura Valor Default
            Call ConfigureValorDefault(Me)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub LoadGrid()

        Try

            'Limpa erro
            frmMain.errInfo.Clear()

            Dim sStatus As String = ""

            'Status
            If cboStatusFiltro.SelectionLength > 0 Then
                For i = 0 To UBound(cboStatusFiltro.CheckedValues)
                    sStatus &= IIf(sStatus = "", "", ",") & cboStatusFiltro.CheckedValues(i).ToString
                Next
            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Carrega Grid
            Call oClsPrdPlanejamentoLegado.LoadGrid(IIf(cboCliente.SelectedIndex = -1, -1, cboCliente.SelectedValue),
                                                    IIf(dtpDataNecessidadeInicioFiltro.Checked = True, dtpDataNecessidadeInicioFiltro.Value, ""),
                                                    IIf(dtpDataNecessidadeTerminoFiltro.Checked = True, dtpDataNecessidadeTerminoFiltro.Value, ""),
                                                    grdAnalitico,
                                                    grdListagem,
                                                    grdProcesso, _
                                                    sStatus)

            LoadGridFuncionarioAtual()
            LoadGridMaquinaAtual()


            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub


    Private Sub LoadGridFuncionarioAtual()
        Try
            oClsPrdPlanejamentoLegado.LoadGridFuncionarioAtual(grdFuncionarioAtual)
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub
    Private Sub LoadGridMaquinaAtual()
        Try
            oClsPrdPlanejamentoLegado.LoadGridMaquinaAtual(grdMaquinaAtual)
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub EditarOrdemProducao(ByVal oGrid As GridEX)

        Try


            Dim oUserControl As UserControl
            Dim oAssembly As Assembly = GetExecutingAssembly()

            oUserControl = oAssembly.CreateInstance("INTERACTI." & "usrPrdOrdemProducaoManual")
            oUserControl.Dock = DockStyle.Fill
            oUserControl.Tag = "ID:" + CStr(oGrid.CurrentRow.Cells.Item("codigo_ordem_producao").Value)

            frmMain.LoadPage("Ordem Produção", "Ordem de Produção", oUserControl, True)

            Application.DoEvents()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub RecalcularDataProducao(ByVal lCodigoOrdemProducao As Long)
        Try

            '1744 - PLANEJAMENTO - RECALCULAR DATA PRODUÇÃO
            If VerificaDireito(1744, gcUpdate) = False Then
                frmMain.Informacao("Usuário sem permissão necessária para Realcular data Produção", Color.Red)
                Exit Sub
            End If

            If MsgBox("Gostaria de recalcular a Data de Produção? Este procedimento não é reversível.", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) <> MsgBoxResult.Yes Then Exit Sub

            oClsPrdPlanejamentoLegado.UpdateRecalcularDataProducao(lCodigoOrdemProducao)

            frmMain.Informacao(Mensagem.RegistroAlterado)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub


#End Region


End Class
