Public Class usrEst000000001

#Region "::: CONTROLES :::"

    Private Sub usrEst000000001_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown, _
                                                                                                                    cboProduto.KeyUp

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

    Private Sub usrEst000000001_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

    Private Sub usrEst000000001_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

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
            oComboBoxFind = cboProduto

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            cboProduto.Focus()

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
            Call LoadCombo(cboProduto, "sp_select_combo_cadastro_basico_item_descricao " & goUsuario.iEmpresa & ", NULL, NULL, " & CInt(TipoItem.produto))

            'Carrega ComboBox - Status
            cboStatus.Items.Clear()
            cboStatus.Items.Add("ABAIXO DO PONTO REPOSIÇÃO", 1)
            cboStatus.Items.Add("ACIMA DO PONTO REPOSIÇÃO", 2)
            cboStatus.Items.Add("SALDO IGUAL A ZERO", 3)
            cboStatus.Items.Add("SALDO NEGATIVO", 4)
            cboStatus.Items.Add("SALDO POSITIVO", 5)

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
            ReDim goCrystalReport.sReportParameter(5)

            'Relatório
            goCrystalReport.sReport = goCrystalReport.sPath & "EST000000001.rpt"

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
            goCrystalReport.sReportParameter(4).sValue = IIf(cboProduto.SelectedIndex = -1, -1, cboProduto.SelectedValue)
            'Seta Paramentro - Status
            goCrystalReport.sReportParameter(5).sParamenter = "@status"
            goCrystalReport.sReportParameter(5).sValue = IIf(cboStatus.SelectedIndex = -1, -1, cboStatus.SelectedValue)

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
