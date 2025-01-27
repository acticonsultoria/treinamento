Imports Janus.Windows.GridEX
Imports CrystalDecisions.CrystalReports.Engine

Public Class frmFatEmissaoNFeEmail

#Region "::: VARIAVEIS :::"

    'Variável da Classe
    Private oClsFatEmissaoNFe As New clsUsrFatEmissaoNFe
    Private oGrid As GridEX

#End Region

#Region "::: PROPERTIE :::"

    Public Property Grid() As GridEX
        Get
            Return oGrid
        End Get
        Set(ByVal value As GridEX)
            oGrid = value
        End Set
    End Property

#End Region

#Region "::: CONTROLES :::"

    Private Sub frmFatEmissaoNFeHistorico_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarFormulario()

    End Sub

    Private Sub frmFatEmissaoNFeHistorico_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        Me.Top = (frmMain.tabMain.Top + ((frmMain.tabMain.Height - Me.Height) / 2) + gcFormAjust)
        Me.Left = (frmMain.tabMain.Left + ((frmMain.tabMain.Width - Me.Width) / 2))

    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click

        'Fecha o Controle
        Me.Dispose()

    End Sub

    Private Sub grdListagem_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdListagem.RowDoubleClick

        Try

            'Verifica se é Carta de Correção
            If IsDBNull(grdListagem.CurrentRow.Cells("codigo_emissao_capa").Value) = False Then

                Select Case grdListagem.CurrentColumn.Key
                    Case "imprimir" : Call ImprimirCartaCorrecao() : Me.Dispose()
                    Case "email" : Call EmailCartaCorrecao() : Me.Dispose()
                End Select

            Else
                'Informa o Usuário
                frmMain.Informacao("Este Histórico não é uma Carta de Correção.", gColorInformacaoErro)
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: FUNCTION / SUB :::"

    Private Sub ConfigurarFormulario()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Carrega Dados da Nota Fiscal
            txtChaveAcesso.Text = oGrid.CurrentRow.Cells("chave_acesso").Value
            txtProtocolo.Text = oGrid.CurrentRow.Cells("protocolo").Value
            txtNotaFiscal.Text = Format(oGrid.CurrentRow.Cells("nota_fiscal").Value, "000000000")
            txtSerie.Text = Format(oGrid.CurrentRow.Cells("serie").Value, "000")
            txtDataEmissao.Text = oGrid.CurrentRow.Cells("data_emissao").Value

            'Carrega Dados da Emissão de Nota Fiscal Eletrônica
            Call oClsFatEmissaoNFe.LoadGridHistorico(grdListagem, _
                                                     oGrid.CurrentRow.Cells("codigo").Value)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub ImprimirCartaCorrecao()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Redimenciona Vetor
            ReDim goCrystalReport.sReportParameter(2)
            'Seta Parametros
            goCrystalReport.sReportParameter(0).sParamenter = "@codigo_emissao_capa"
            goCrystalReport.sReportParameter(0).sValue = grdListagem.CurrentRow.Cells("codigo_emissao_capa").Value
            goCrystalReport.sReportParameter(1).sParamenter = "@sequencia"
            goCrystalReport.sReportParameter(1).sValue = grdListagem.CurrentRow.Cells("sequencia").Value
            goCrystalReport.sReportParameter(2).sParamenter = "@codigo_empresa"
            goCrystalReport.sReportParameter(2).sValue = goUsuario.iEmpresa
            goCrystalReport.sReport = goCrystalReport.sPath & "FAT000000005.rpt"

            Dim oReport As New usrReport
            oReport.Dock = DockStyle.Fill

            'Abre Relatório
            frmMain.LoadPageReport("FAT000000005", "Carta de Correção", oReport)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub EmailCartaCorrecao()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Váriaveis Locais
            Dim oRptDocument As New ReportDocument

            'Abre Relatório
            oRptDocument.Load(goCrystalReport.sPath & "FAT000000005.rpt", _
                              CrystalDecisions.Shared.OpenReportMethod.OpenReportByTempCopy)

            'Seta Parametros Relatório
            oRptDocument.SetParameterValue("@codigo_emissao_capa", grdListagem.CurrentRow.Cells("codigo_emissao_capa").Value)
            oRptDocument.SetParameterValue("@sequencia", grdListagem.CurrentRow.Cells("sequencia").Value)
            oRptDocument.SetParameterValue("@codigo_empresa", goUsuario.iEmpresa)

            'Abre Conexão com o Banco de Dados
            For i = 0 To oRptDocument.DataSourceConnections.Count - 1
                oRptDocument.DataSourceConnections.Item(i).SetConnection(goDatabase.sDataSource, goDatabase.sInitialCatalog, goDatabase.sUserID, goDatabase.sPassword)
            Next

            'Exporta para Arquivo PDF
            oRptDocument.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, _
                                      goConfiguracaoNFe.sPastaImpressao & "CCe_" & txtNotaFiscal.Text.Trim & ".pdf")

            'Limpa Váriavel
            oRptDocument = Nothing

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

            'Formulário de Envio de E-mail
            Dim oForm As New frmEmail

            'Seta Parâmetros do Formulário
            oForm.Para = ""
            oForm.Subject = goUsuario.sEmpresa & " - Carta de Correção da NFe " & txtNotaFiscal.Text.Trim & " - Chave de Acesso: " & txtChaveAcesso.Text.Trim
            oForm.Anexo = goConfiguracaoNFe.sPastaImpressao & "CCe_" & txtNotaFiscal.Text.Trim & ".pdf"
            oForm.AnexoPath = goConfiguracaoNFe.sPastaImpressao & "CCe_" & txtNotaFiscal.Text.Trim & ".pdf"
            oForm.CodigoParceiroNegocio = grdListagem.CurrentRow.Cells("codigo_parceiro_negocio").Value

            'Abre Formulário
            ConfigureMaskEdit(oForm) : oForm.ShowDialog()

            'Limpa Váriavel
            oRptDocument = Nothing

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

End Class