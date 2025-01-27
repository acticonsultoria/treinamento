Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls
Imports CrystalDecisions.CrystalReports.Engine
Imports System.Math
Imports System.Reflection
Imports System.Reflection.Assembly

Public Class usrPrdPool

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oclsUsrPrdPool As New clsUsrPrdPool
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

    Private Sub grdListagem_RowDoubleClick(sender As Object, e As RowActionEventArgs) Handles grdListagem.RowDoubleClick
        Try

            'Verifica se a Coluna pressionada é Válida
            If IsNothing(grdListagem.CurrentColumn) Then Exit Sub

            Select Case grdListagem.CurrentColumn.Key

                Case "finalizar"
                    If MsgBox("Deseja finalizar a operação e enviar para a próxima etapa? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Validação") = vbNo Then Exit Sub

                    'Atualiza
                    oclsUsrPrdPool.Finalizar(grdListagem.GetValue("codigo_ordem_producao"))

                    'Informa o usuário
                    frmMain.Informacao("Pool atualizado com sucesso!", Color.Blue)

                    'Carrega a grid
                    LoadGrid()

                Case "ordem_producao" : Call EditarOrdemProducao(sender)

            End Select

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub grdListagem_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdListagem.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem.Name, _
                                     iFormulario, _
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
                                     iFormulario)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGrid.Click

        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdListagem)

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

            'Carrega Combo
            Call LoadCombo(cboCentroTrabalhoFiltro, "sp_select_combo_cadastro_basico_centro_trabalho " & goUsuario.iEmpresa & ",'TODOS'")

            dtpDataNecessidadeInicioFiltro.Value = "01/" & Month(Now) & "/" & Year(Now) : dtpDataNecessidadeInicioFiltro.Checked = False
            dtpDataNecessidadeTerminoFiltro.Value = DateAdd(DateInterval.Day, -1, DateAdd(DateInterval.Month, 1, dtpDataNecessidadeInicioFiltro.Value)) : dtpDataNecessidadeTerminoFiltro.Checked = False

            ConfiguraGrid(grdListagem, iFormulario)

            'Verifica Direito
            btnExcelGrid.Enabled = VerificaDireito(Formulario.ProducaoForecast, gcPrint)

            'Seta Focu
            cboCentroTrabalhoFiltro.Focus()

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

            If ValidaCampo(cboCentroTrabalhoFiltro, lblCentroTrabalhoFiltro) = False Then
                Exit Sub
            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            Dim sCentroTrabalho As String = ""

            For Each oItem In cboCentroTrabalhoFiltro.CheckedValues
                sCentroTrabalho += IIf(sCentroTrabalho = "", "", ",") + CStr(oItem.ToString)
            Next
            Dim sStatus As String = ""


            'Carrega Grid
            oclsUsrPrdPool.LoadGrid(grdListagem,
                                    sCentroTrabalho,
                                    IIf(dtpDataNecessidadeInicioFiltro.Checked = False, "", dtpDataNecessidadeInicioFiltro.Value),
                                    IIf(dtpDataNecessidadeTerminoFiltro.Checked = False, "", dtpDataNecessidadeTerminoFiltro.Value),
                                    chkSomenteInLoco.Checked)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
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

#End Region

End Class


