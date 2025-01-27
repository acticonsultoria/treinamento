Imports Janus.Windows.GridEX
Imports CrystalDecisions.CrystalReports.Engine
Imports System.IO
Imports CrystalDecisions.Shared

Public Class frmFatEmissaoNFeHistorico

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

    Private Sub frmFatEmissaoNFeHistorico_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter : Call Control_Enter(sender)

                Case Keys.Escape : Me.Dispose()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub frmFatEmissaoNFeHistorico_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarFormulario()

    End Sub

    Private Sub btnAgruparGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGrid.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdHistorico.GroupByBoxVisible = True Then
                'Oculta Grupo
                grdHistorico.GroupByBoxVisible = False
            Else
                'Exibe Grupo
                grdHistorico.GroupByBoxVisible = True
                grdHistorico.HideColumnsWhenGrouped = InheritableBoolean.True
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnConfigurarGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGrid.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdHistorico
            oForm.NomeFormulario = Formulario.FaturamentoEmissaoNFe
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdHistorico, Formulario.FaturamentoEmissaoNFe)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnExcelGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGrid.Click

        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdHistorico)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click

        Try

            'Fecha o Controle
            Me.Dispose()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdHistorico_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdHistorico.RowDoubleClick

        Try

            'Verifica Linha Pressionada
            If IsNothing(grdHistorico.CurrentColumn) Then Exit Sub

            Select Case grdHistorico.CurrentColumn.Key
                Case "imprimir"
                    Select Case e.Row.Cells("tipo").Value
                        Case "CANCELAMENTO" : Call ImprimirDanfeCancelado()
                        Case "CARTA DE CORREÇÃO" : Call ImprimirCartaCorrecao()
                    End Select
                    Me.Dispose()
                Case "email"
                    Select Case e.Row.Cells("tipo").Value
                        Case "CANCELAMENTO" : Call EmailCancelamentoNFe()
                        Case "CARTA DE CORREÇÃO" : Call EmailCartaCorrecao()
                    End Select
            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdHistorico_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdHistorico.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdHistorico, _
                                     Formulario.FaturamentoEmissaoNFe)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdHistorico_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdHistorico.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdHistorico.Name, _
                                     Formulario.FaturamentoEmissaoNFe, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdHistorico_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdHistorico.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdHistorico.Name, _
                                          Formulario.FaturamentoEmissaoNFe, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

#End Region

#Region "::: FUNCTION / SUB :::"

    Private Sub ConfigurarFormulario()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Ícone
            Me.Icon = frmMain.Icon

            'Adiciona KeyUP
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf frmFatEmissaoNFeHistorico_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Seta Tamanho / Posição do Formulário
            Me.Size = frmMain.tlpMain.Size : Me.Location = New Point(0, 23)

            'Carrega Dados da Nota Fiscal
            txtChaveAcesso.Text = IIf(IsDBNull(oGrid.CurrentRow.Cells("chave_acesso").Value), "", oGrid.CurrentRow.Cells("chave_acesso").Value)
            txtProtocolo.Text = IIf(IsDBNull(oGrid.CurrentRow.Cells("protocolo").Value), "", oGrid.CurrentRow.Cells("protocolo").Value)
            txtNotaFiscal.Text = oGrid.CurrentRow.Cells("nota_fiscal").Value
            txtSerie.Text = IIf(IsDBNull(oGrid.CurrentRow.Cells("serie").Value), "", oGrid.CurrentRow.Cells("serie").Value)
            txtDataEmissao.Text = oGrid.CurrentRow.Cells("data_emissao").Value

            'Carrega Dados da Emissão de Nota Fiscal Eletrônica
            Call oClsFatEmissaoNFe.LoadGridHistorico(grdHistorico, _
                                                     oGrid.CurrentRow.Cells("codigo").Value)

            'Configura Grid
            Call ConfiguraGrid(grdHistorico, Formulario.FaturamentoEmissaoNFe)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub ImprimirCartaCorrecao()

        Try

            'Verifica se o Usuário tem Direito de Imprimir
            If VerificaDireito(Formulario.FaturamentoEmissaoNFe, gcPrint) = False Then
                frmMain.Informacao(Mensagem.DireitoImprimir)
                Exit Sub
            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Redimenciona Vetor
            ReDim goCrystalReport.sReportParameter(2)
            'Seta Parametros
            goCrystalReport.sReportParameter(0).sParamenter = "@codigo_emissao_capa"
            goCrystalReport.sReportParameter(0).sValue = grdHistorico.CurrentRow.Cells("codigo_emissao_capa").Value
            goCrystalReport.sReportParameter(1).sParamenter = "@sequencia"
            goCrystalReport.sReportParameter(1).sValue = grdHistorico.CurrentRow.Cells("sequencia").Value
            goCrystalReport.sReportParameter(2).sParamenter = "@codigo_empresa"
            goCrystalReport.sReportParameter(2).sValue = goUsuario.iEmpresa
            goCrystalReport.sReport = goCrystalReport.sPath & "FAT000000005.rpt"

            Dim oReport As New usrReport
            oReport.Dock = DockStyle.Fill

            'Abre Relatório
            frmMain.LoadPageReport("FAT000000005", "CCe", oReport, frmMain.tabMain)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub ImprimirDanfeCancelado()

        Try

            'Verifica se o Usuário tem Direito de Imprimir
            If VerificaDireito(Formulario.FaturamentoEmissaoNFe, gcPrint) = False Then
                frmMain.Informacao(Mensagem.DireitoImprimir)
                Exit Sub
            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Redimenciona Vetor
            ReDim goCrystalReport.sReportParameter(1)
            'Seta Parametros
            goCrystalReport.sReportParameter(0).sParamenter = "@codigo_emissao_capa"
            goCrystalReport.sReportParameter(0).sValue = grdHistorico.CurrentRow.Cells("codigo_emissao_capa").Value
            goCrystalReport.sReportParameter(1).sParamenter = "@codigo_empresa"
            goCrystalReport.sReportParameter(1).sValue = goUsuario.iEmpresa
            goCrystalReport.sReport = goCrystalReport.sPath & LoadDescricao("sp_select_faturamento_emissao_relatorio_danfe " & goUsuario.iEmpresa & ", " & grdHistorico.CurrentRow.Cells("codigo_emissao_capa").Value)

            Dim oReport As New usrReport
            oReport.Dock = DockStyle.Fill

            'Abre Relatório
            frmMain.LoadPageReport("FAT000000003", "DANFE - Documento Auxiliar de Nota Fiscal Eletrônica", oReport)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub EmailCartaCorrecao()

        Try

            'Verifica se o Usuário tem Direito de Imprimir
            If VerificaDireito(Formulario.FaturamentoEmissaoNFe, gcPrint) = False Then
                frmMain.Informacao(Mensagem.DireitoImprimir)
                Exit Sub
            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Váriaveis Locais
            Dim oRptDocument As New ReportDocument

            'Abre Relatório
            oRptDocument.Load(goCrystalReport.sPath & "FAT000000005.rpt", _
                              CrystalDecisions.Shared.OpenReportMethod.OpenReportByTempCopy)


            'Seta Parametros Relatório
            oRptDocument.SetParameterValue("@codigo_emissao_capa", grdHistorico.CurrentRow.Cells("codigo_emissao_capa").Value)
            oRptDocument.SetParameterValue("@sequencia", grdHistorico.CurrentRow.Cells("sequencia").Value)
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

            'XML
            Dim oClsNFeArquivoEnvio As New clsNFeArquivoEnvio_V4
            Dim sMensagemErro As String = ""
            Dim sArquivoXML As String = ""

            'Carrega Arquivo XML
            If oClsNFeArquivoEnvio.XMLCartaCorrecao(grdHistorico.CurrentRow.Cells("codigo_emissao_capa").Value, _
                                                    grdHistorico.CurrentRow.Cells("sequencia").Value, _
                                                    txtChaveAcesso.Text, _
                                                    sArquivoXML, _
                                                    sMensagemErro) = False Then

                'Informa o Usuário o Erro Ocorrido
                frmMain.Informacao(Mensagem.Erro, sMensagemErro)
                Exit Sub

            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

            'Enviar E-mail
            Call EnviarEmail(goUsuario.sEmpresa & " - CCe da NFe " & txtNotaFiscal.Text.Trim & " - Chave de Acesso: " & txtChaveAcesso.Text.Trim, _
                             "", _
                             goConfiguracaoNFe.sPastaImpressao & "CCe_" & txtNotaFiscal.Text.Trim & ".pdf" & IIf(sArquivoXML = "", "", ";" & sArquivoXML), _
                             goConfiguracaoNFe.sPastaImpressao & "CCe_" & txtNotaFiscal.Text.Trim & ".pdf" & IIf(sArquivoXML = "", "", ";" & sArquivoXML), _
                             "", _
                             grdHistorico.CurrentRow.Cells("codigo_parceiro_negocio").Value)

            'Limpa Váriavel
            oRptDocument = Nothing

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub EmailCancelamentoNFe()

        Try

            'Verifica se o Usuário tem Direito de Imprimir
            If VerificaDireito(Formulario.FaturamentoEmissaoNFe, gcPrint) = False Then
                frmMain.Informacao(Mensagem.DireitoImprimir)
                Exit Sub
            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Váriaveis Locais
            Dim oRptDocument As New ReportDocument
            Dim oClsNFeArquivoEnvio As New clsNFeArquivoEnvio_V4
            Dim sArquivoEnvio As String = ""
            Dim sMensagemErro As String = ""
            Dim sArquivoNFe As String = ""
            Dim sArquivoProtocoloNFe As String = ""
            Dim sArquivoCancelamentoNFe As String = ""
            Dim sArquivoProtocoloCancelamentoNFe As String = ""
            Dim sNotaFiscal As String = ""
            Dim sChaveAcesso As String = ""
            Dim lCodigoParceiroNegocio As Long
            Dim lCodigoTituloCapa As Long
            Dim oClsFatEmissaoNFe As New clsUsrFatEmissaoNFe

            'Carrega Dados da NF-e
            oClsFatEmissaoNFe.LoadDadosNFe(grdHistorico.CurrentRow.Cells("codigo_emissao_capa").Value, _
                                           sArquivoNFe, _
                                           sArquivoProtocoloNFe, _
                                           sArquivoCancelamentoNFe, _
                                           sArquivoProtocoloCancelamentoNFe, _
                                           sChaveAcesso, _
                                           sNotaFiscal, _
                                           lCodigoParceiroNegocio, _
                                           lCodigoTituloCapa)

            'Verifica se foi possível gerar o Arquivo
            If oClsNFeArquivoEnvio.ArquivoNFe(sArquivoNFe, _
                                              sArquivoProtocoloNFe, _ 
                                              sChaveAcesso, _
                                              sArquivoEnvio, _
                                              sMensagemErro) = True Then

                'Abre Relatório
                oRptDocument.Load(goCrystalReport.sPath & LoadDescricao("sp_select_faturamento_emissao_relatorio_danfe " & goUsuario.iEmpresa & ", " & grdHistorico.CurrentRow.Cells("codigo_emissao_capa").Value), _
                                  CrystalDecisions.Shared.OpenReportMethod.OpenReportByTempCopy)

                'Seta Parametros Relatório
                oRptDocument.SetParameterValue("@codigo_emissao_capa", grdHistorico.CurrentRow.Cells("codigo_emissao_capa").Value)
                oRptDocument.SetParameterValue("@codigo_empresa", goUsuario.iEmpresa)

                'Abre Conexão com o Banco de Dados
                For i = 0 To oRptDocument.DataSourceConnections.Count - 1
                    oRptDocument.DataSourceConnections.Item(i).SetConnection(goDatabase.sDataSource, goDatabase.sInitialCatalog, goDatabase.sUserID, goDatabase.sPassword)
                Next

                'Váriaveis Locais
                Dim sArquivo As String = System.IO.Path.GetTempPath & sNotaFiscal & ".pdf"

                'Verifica se o Arquivo Existe
                If File.Exists(sArquivo) Then File.Delete(sArquivo)

                'Exporta para Arquivo PDF
                oRptDocument.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, _
                                          sArquivo)

                'Limpa Váriavel
                oRptDocument = Nothing

                'Seta Cursor do Mouse
                Cursor.Current = Cursors.Default

                'Enviar E-mail
                Call EnviarEmail(goUsuario.sEmpresa & " - Cancelamento da NFe " & sNotaFiscal & " - Chave de Acesso: " & sChaveAcesso, _
                                 LoadDescricao("sp_select_faturamento_emissao_destinatario_email " & goUsuario.iEmpresa & ", " & grdHistorico.CurrentRow.Cells("codigo_emissao_capa").Value), _
                                 sArquivo & "; " & sArquivoEnvio, _
                                 sArquivo & "; " & sArquivoEnvio, _
                                 "", _
                                 lCodigoParceiroNegocio, _
                                 "", _
                                 -1)

                'Limpa Váriavel
                oRptDocument = Nothing

            Else
                'Informa o Usuário sobre o Erro Ocorrido
                frmMain.Informacao(Mensagem.Erro, sMensagemErro)
            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class