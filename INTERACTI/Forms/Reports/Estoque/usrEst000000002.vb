Public Class usrEst000000002

#Region "::: CONTROLES :::"

    Private Sub usrEst000000002_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown, _
                                                                                                                    cboItem.KeyUp

        Try

            Select Case e.KeyCode

                Case Keys.F3

                    Select Case sender.Name
                        Case "cboItem" : Call btnProcurarItem_Click(btnProcurarItem, System.EventArgs.Empty)
                    End Select

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub usrEst000000002_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

    Private Sub usrEst000000002_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        'Reposiciona UserControl
        Me.Top = (frmMain.picImage.Top + ((frmMain.picImage.Height - Me.Height) / 2))
        Me.Left = ((frmMain.picImage.Width - Me.Width) / 2)

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
            sItemEstoqueFind = "S"
            oComboBoxFind = cboItem

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            cboItem.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnVisualizarImpressao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVisualizarImpressao.Click

        Try

            'Visualizar Impressão
            Call VisualizarImpressao()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click

        'Deleta Aba
        If TypeOf Me.Parent Is Form Then Me.Parent.Dispose() Else If TypeOf Me.Parent Is Panel Then Me.Parent.Controls.Remove(Me) Else frmMain.tabMain.TabPages.Remove(Me.Parent)
        'Fecha o Controle
        Me.Dispose()

    End Sub

#End Region

#Region "::: FUNCTION / SUB :::"

    Private Sub ConfigurarUserControl()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Carrega ComboBox
            Call LoadCombo(cboDeposito, "sp_select_combo_cadastro_basico_deposito " & goUsuario.iEmpresa)
            Call LoadCombo(cboGrupoItem, "sp_select_combo_cadastro_basico_grupo_item " & goUsuario.iEmpresa)
            Call LoadCombo(cboItem, "sp_select_combo_cadastro_basico_item_descricao " & goUsuario.iEmpresa & ", NULL, NULL, " & CInt(TipoItem.produto))

            'Configura DateTimePicker
            dtpDataInicio.Value = Now.Date : dtpDataInicio.Checked = False
            dtpDataTermino.Value = Now.Date : dtpDataTermino.Checked = False

            'Seta Focu
            cboDeposito.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub VisualizarImpressao()

        Try

            'Redimensiona Vetor
            ReDim goCrystalReport.sReportParameter(6)

            'Relatório
            goCrystalReport.sReport = goCrystalReport.sPath & "EST000000002.rpt"

            'Seta Paramentro - Nome
            goCrystalReport.sReportParameter(0).sParamenter = "usuario"
            goCrystalReport.sReportParameter(0).sValue = goUsuario.sNome
            'Seta Paramentro - Empresa
            goCrystalReport.sReportParameter(1).sParamenter = "@codigo_empresa"
            goCrystalReport.sReportParameter(1).sValue = goUsuario.iEmpresa
            'Seta Paramentro - Código Depósito
            goCrystalReport.sReportParameter(2).sParamenter = "@codigo_deposito"
            goCrystalReport.sReportParameter(2).sValue = IIf(cboDeposito.SelectedIndex = -1, -1, cboDeposito.SelectedValue)
            'Seta Paramentro - Código Grupo Item
            goCrystalReport.sReportParameter(3).sParamenter = "@codigo_grupo_item"
            goCrystalReport.sReportParameter(3).sValue = IIf(cboGrupoItem.SelectedIndex = -1, -1, cboGrupoItem.SelectedValue)
            'Seta Paramentro - Item
            goCrystalReport.sReportParameter(4).sParamenter = "@codigo_item"
            goCrystalReport.sReportParameter(4).sValue = IIf(cboItem.SelectedIndex = -1, -1, cboItem.SelectedValue)
            'Seta Paramentro - Data Início
            goCrystalReport.sReportParameter(5).sParamenter = "@data_inicio"
            goCrystalReport.sReportParameter(5).sValue = IIf(dtpDataInicio.Checked = False, "NULL", dtpDataInicio.Value)
            'Seta Paramentro - Data Término
            goCrystalReport.sReportParameter(6).sParamenter = "@data_termino"
            goCrystalReport.sReportParameter(6).sValue = IIf(dtpDataTermino.Checked = False, "NULL", dtpDataTermino.Value)

            'Abre Relatório
            Dim oReport = New usrReport
            oReport.Dock = DockStyle.Fill
            frmMain.LoadPageReport(goCrystalReport.sReport, Me.Parent.Text, oReport)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

End Class
