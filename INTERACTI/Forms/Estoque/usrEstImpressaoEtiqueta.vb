Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls

Public Class usrEstImpressaoEtiqueta

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsEstImpressaoEtiqueta As New clsUsrEstImpressaoEtiqueta

#End Region

#Region "::: CONTROLES :::"

    Private Sub usrEstImpressaoEtiqueta_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp

        Try

            Select Case e.KeyCode

                Case Keys.Enter
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then
                        ' Call LoadGrid()
                    End If

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub usrEstImpressaoEtiqueta_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

    Private Sub usrEstImpressaoEtiqueta_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        'Reposiciona Formulário
        Me.Top = (frmMain.picImage.Top + ((frmMain.picImage.Height - Me.Height) / 2))
        Me.Left = ((frmMain.picImage.Width - Me.Width) / 2)

    End Sub

    Private Sub btnExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        'Exporta Grid para Excel
        Call ExportExcel(grdListagem)

    End Sub

    Private Sub btnNovo1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        'Alterna Aba
        tabMain.TabPages.Remove(pagLista)

        'Prepara o Formulário para Inserção de um Novo Registro
        'Call Novo()

    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click

        'Deleta Aba
        frmMain.tabMain.TabPages.Remove(Me.Parent)
        'Fecha o Controle
        Me.Dispose()

    End Sub

    Private Sub cboTipoEtiqueta_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipoEtiqueta.SelectedIndexChanged
        Try
            If cboTipoEtiqueta.SelectedIndex = -1 Then Exit Sub

            If cboTipoEtiqueta.SelectedValue = 3 Or cboTipoEtiqueta.SelectedValue = 6 Then
                oClsEstImpressaoEtiqueta.LoadGrid(grdListagem, -1, cboTipoEtiqueta.SelectedValue, cboCliente.SelectedValue)
                cboCliente.SelectedIndex = -1
                cboCliente.Enabled = False
                cboNumeroDocumento.Enabled = False
                cboNumeroDocumento.SelectedIndex = -1
                grdListagem.RootTable.Columns("produto").Caption = "Produto"
                grdListagem.RootTable.Columns("descricao").Caption = "Descrição"

            ElseIf cboTipoEtiqueta.SelectedValue = 5 Then
                'oClsEstImpressaoEtiqueta.LoadGrid(grdListagem, -1, cboTipoEtiqueta.SelectedValue, cboCliente.SelectedValue)
                LoadCombo(cboCliente, "sp_select_combo_estoque_etiqueta_parceiro_negocio " & goUsuario.iEmpresa & ", " & cboTipoEtiqueta.SelectedValue)
                cboCliente.SelectedIndex = -1
                cboCliente.Enabled = True
                cboNumeroDocumento.Enabled = False
                cboNumeroDocumento.SelectedIndex = -1
                grdListagem.RootTable.Columns("produto").Caption = "Telefone"
                grdListagem.RootTable.Columns("descricao").Caption = "Email"
            Else
                oClsEstImpressaoEtiqueta.LoadGrid(grdListagem, -1, -1, -1)
                cboCliente.Enabled = True
                cboNumeroDocumento.Enabled = False
                cboNumeroDocumento.SelectedIndex = -1
                LoadCombo(cboCliente, "sp_select_combo_estoque_etiqueta_parceiro_negocio " & goUsuario.iEmpresa & ", " & cboTipoEtiqueta.SelectedValue)
                grdListagem.RootTable.Columns("produto").Caption = "Produto"
                grdListagem.RootTable.Columns("descricao").Caption = "Descrição"
            End If
        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub cboNumeroDocumento_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboNumeroDocumento.SelectedIndexChanged
        Try
            oClsEstImpressaoEtiqueta.LoadGrid(grdListagem, cboNumeroDocumento.SelectedValue, cboTipoEtiqueta.SelectedValue, cboCliente.SelectedValue)
        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        Try
            Call ImprimirEtiqueta()
        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
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

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            cboCliente.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub cboCliente_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboCliente.SelectedIndexChanged
        Try
            If cboCliente.SelectedIndex = -1 Then
                cboNumeroDocumento.SelectedIndex = -1
                cboNumeroDocumento.Enabled = False
            Else
                cboNumeroDocumento.SelectedIndex = -1
                cboNumeroDocumento.Enabled = True
                If cboTipoEtiqueta.SelectedValue = 5 Then
                    oClsEstImpressaoEtiqueta.LoadGrid(grdListagem, -1, cboTipoEtiqueta.SelectedValue, cboCliente.SelectedValue)
                    cboNumeroDocumento.Enabled = False
                    

                End If
                LoadCombo(cboNumeroDocumento, "sp_select_combo_estoque_etiqueta_numero_documento " & goUsuario.iEmpresa & ", " & cboTipoEtiqueta.SelectedValue & ", " & cboCliente.SelectedValue)
            End If

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

            'Verifica Direito

            LoadCombo(cboTipoEtiqueta, "sp_select_combo_static_estoque_etiqueta")
            LoadCombo(cboCliente, "sp_select_combo_estoque_etiqueta_parceiro_negocio " & goUsuario.iEmpresa & ", " & -1)
            LoadCombo(cboNumeroDocumento, "sp_select_combo_estoque_etiqueta_numero_documento " & goUsuario.iEmpresa & ", " & -1 & ", " & -1)

            cboCliente.Enabled = False
            cboCliente.SelectedIndex = -1
            cboNumeroDocumento.Enabled = False
            cboNumeroDocumento.SelectedIndex = -1

            ConfigurarDataMemberGrid(grdListagem)


            'Seta Focu
            cboTipoEtiqueta.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub ImprimirEtiqueta()
        Try
            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor
            If VerificaSelecaoRow(grdListagem) = True Then


                Dim sCodigo As String = ""
                For Each oRow As GridEXRow In grdListagem.GetCheckedRows
                    sCodigo += oRow.Cells.Item("codigo_item").Value & "," _
                        & oRow.Cells.Item("quantidade_impressao").Value & "," _
                        & oRow.Cells.Item("quantidade_etiqueta").Value & ";"
                Next

                Select Case cboTipoEtiqueta.SelectedValue
                    Case 1

                        'Redimenciona Vetor
                        ReDim goCrystalReport.sReportParameter(3)
                        'Seta Parametros
                        goCrystalReport.sReportParameter(0).sParamenter = "usuario"
                        goCrystalReport.sReportParameter(0).sValue = goUsuario.sNome
                        goCrystalReport.sReportParameter(1).sParamenter = "@codigo"
                        goCrystalReport.sReportParameter(1).sValue = sCodigo
                        goCrystalReport.sReportParameter(2).sParamenter = "@codigo_empresa"
                        goCrystalReport.sReportParameter(2).sValue = goUsuario.iEmpresa
                        goCrystalReport.sReportParameter(3).sParamenter = "@codigo_pedido"
                        goCrystalReport.sReportParameter(3).sValue = cboNumeroDocumento.SelectedValue
                        goCrystalReport.sReport = goCrystalReport.sPath & "EST000000010_VENDA.rpt"

                        Dim oReport As New usrReport
                        oReport.Dock = DockStyle.Fill

                        'Abre Relatório
                        frmMain.LoadPageReport("EST000000010_VENDA", "Etiqueta - Pedido de Venda", oReport)


                    Case 2
                        'Redimenciona Vetor
                        ReDim goCrystalReport.sReportParameter(3)
                        'Seta Parametros
                        goCrystalReport.sReportParameter(0).sParamenter = "usuario"
                        goCrystalReport.sReportParameter(0).sValue = goUsuario.sNome
                        goCrystalReport.sReportParameter(1).sParamenter = "@codigo"
                        goCrystalReport.sReportParameter(1).sValue = sCodigo
                        goCrystalReport.sReportParameter(2).sParamenter = "@codigo_empresa"
                        goCrystalReport.sReportParameter(2).sValue = goUsuario.iEmpresa
                        goCrystalReport.sReportParameter(3).sParamenter = "@codigo_emissao_capa"
                        goCrystalReport.sReportParameter(3).sValue = cboNumeroDocumento.SelectedValue
                        goCrystalReport.sReport = goCrystalReport.sPath & "EST000000010_NF.rpt"

                        Dim oReport As New usrReport
                        oReport.Dock = DockStyle.Fill

                        'Abre Relatório
                        frmMain.LoadPageReport("EST000000010_NF", "Etiqueta - NF", oReport)
                    Case 3


                        'Redimenciona Vetor
                        ReDim goCrystalReport.sReportParameter(2)
                        'Seta Parametros
                        goCrystalReport.sReportParameter(0).sParamenter = "usuario"
                        goCrystalReport.sReportParameter(0).sValue = goUsuario.sNome
                        goCrystalReport.sReportParameter(1).sParamenter = "@codigo"
                        goCrystalReport.sReportParameter(1).sValue = sCodigo
                        goCrystalReport.sReportParameter(2).sParamenter = "@codigo_empresa"
                        goCrystalReport.sReportParameter(2).sValue = goUsuario.iEmpresa
                        goCrystalReport.sReport = goCrystalReport.sPath & "EST000000010_ESTOQUE.rpt"

                        Dim oReport As New usrReport
                        oReport.Dock = DockStyle.Fill

                        'Abre Relatório
                        frmMain.LoadPageReport("EST000000010_ESTOQUE", "Etiqueta - Estoque", oReport)

                    Case 4
                        'Redimenciona Vetor
                        ReDim goCrystalReport.sReportParameter(3)
                        'Seta Parametros
                        goCrystalReport.sReportParameter(0).sParamenter = "usuario"
                        goCrystalReport.sReportParameter(0).sValue = goUsuario.sNome
                        goCrystalReport.sReportParameter(1).sParamenter = "@codigo"
                        goCrystalReport.sReportParameter(1).sValue = sCodigo
                        goCrystalReport.sReportParameter(2).sParamenter = "@codigo_empresa"
                        goCrystalReport.sReportParameter(2).sValue = goUsuario.iEmpresa
                        goCrystalReport.sReportParameter(3).sParamenter = "@codigo_emissao_capa"
                        goCrystalReport.sReportParameter(3).sValue = cboNumeroDocumento.SelectedValue
                        goCrystalReport.sReport = goCrystalReport.sPath & "EST000000010_EMBALAGEM.rpt"

                        Dim oReport As New usrReport
                        oReport.Dock = DockStyle.Fill

                        'Abre Relatório
                        frmMain.LoadPageReport("EST000000010_EMBALAGEM", "Etiqueta - NF - Embalagem", oReport)

                    Case 5


                        'Redimenciona Vetor
                        ReDim goCrystalReport.sReportParameter(3)
                        'Seta Parametros
                        goCrystalReport.sReportParameter(0).sParamenter = "usuario"
                        goCrystalReport.sReportParameter(0).sValue = goUsuario.sNome
                        goCrystalReport.sReportParameter(1).sParamenter = "@codigo"
                        goCrystalReport.sReportParameter(1).sValue = sCodigo
                        goCrystalReport.sReportParameter(2).sParamenter = "@codigo_empresa"
                        goCrystalReport.sReportParameter(2).sValue = goUsuario.iEmpresa
                        goCrystalReport.sReportParameter(3).sParamenter = "@codigo_parceiro_negocio"
                        goCrystalReport.sReportParameter(3).sValue = cboCliente.SelectedValue
                        goCrystalReport.sReport = goCrystalReport.sPath & "EST000000010_PARCEIRO_NEGOCIO.rpt"

                        Dim oReport As New usrReport
                        oReport.Dock = DockStyle.Fill

                        'Abre Relatório
                        frmMain.LoadPageReport("EST000000010_PARCEIRO_NEGOCIO", "Etiqueta - Estoque", oReport)
                    Case 6


                        'Redimenciona Vetor
                        ReDim goCrystalReport.sReportParameter(2)
                        'Seta Parametros
                        goCrystalReport.sReportParameter(0).sParamenter = "usuario"
                        goCrystalReport.sReportParameter(0).sValue = goUsuario.sNome
                        goCrystalReport.sReportParameter(1).sParamenter = "@codigo"
                        goCrystalReport.sReportParameter(1).sValue = sCodigo
                        goCrystalReport.sReportParameter(2).sParamenter = "@codigo_empresa"
                        goCrystalReport.sReportParameter(2).sValue = goUsuario.iEmpresa
                        goCrystalReport.sReport = goCrystalReport.sPath & "EST000000010_LMTERM.rpt"

                        Dim oReport As New usrReport
                        oReport.Dock = DockStyle.Fill

                        'Abre Relatório
                        frmMain.LoadPageReport("EST000000010_LMTERM", "Etiqueta - Envelope", oReport)

                End Select

            Else
                frmMain.Informacao("Primeiramente selecione um ou mais registros!", Color.Red)
            End If
            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
   
#End Region

End Class
