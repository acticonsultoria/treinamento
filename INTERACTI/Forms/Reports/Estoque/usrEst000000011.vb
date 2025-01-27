Public Class usrEst000000011

#Region "::: CONTROLES :::"

    Private Sub usrEst000000003_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

    Private Sub usrEst000000003_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        'Reposiciona UserControl
        Me.Top = (frmMain.picImage.Top + ((frmMain.picImage.Height - Me.Height) / 2))
        Me.Left = ((frmMain.picImage.Width - Me.Width) / 2)

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

    Private Sub cboPedidoVenda_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPedidoVenda.SelectedIndexChanged

        Try

            'Verifica se Foi Selecionado algum Registro
            If cboPedidoVenda.SelectedIndex <> -1 Then

                'Carrega Combo
                Call LoadCombo(cboItem, "sp_select_combo_cadastro_basico_produto_analise " & goUsuario.iEmpresa & ", " & cboPedidoVenda.SelectedValue, True)

            End If

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

            'Carrega Combo
            Call LoadCombo(cboPedidoVenda, "sp_select_combo_venda_pedido " & goUsuario.iEmpresa)

            'Seta Focu
            cboPedidoVenda.Focus()

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
            ReDim goCrystalReport.sReportParameter(2)

            'Relatório
            goCrystalReport.sReport = goCrystalReport.sPath & "EST000000011.rpt"

            'Seta Paramentro - Empresa
            goCrystalReport.sReportParameter(0).sParamenter = "@codigo_empresa"
            goCrystalReport.sReportParameter(0).sValue = goUsuario.iEmpresa
            'Seta Paramentro - Código Grupo Item
            goCrystalReport.sReportParameter(1).sParamenter = "@codigo_pedido"
            goCrystalReport.sReportParameter(1).sValue = IIf(cboPedidoVenda.SelectedIndex = -1, -1, cboPedidoVenda.SelectedValue)
            'Seta Paramentro - Item
            goCrystalReport.sReportParameter(2).sParamenter = "@codigo_pedido_item"
            goCrystalReport.sReportParameter(2).sValue = IIf(cboItem.SelectedIndex = -1, -1, cboItem.SelectedValue)

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
