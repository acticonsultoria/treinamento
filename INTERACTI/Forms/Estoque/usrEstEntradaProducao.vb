Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports CrystalDecisions.CrystalReports.Engine
Imports System.Math

Public Class usrEstEntradaProducao

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsEstEntradaProducao As New clsUsrEstEntradaProducao

#End Region

#Region "::: CONTROLES :::"

    Private Sub usrEstEntradaProducao_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

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

    Private Sub usrEstEntradaProducao_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

    Private Sub usrEstEntradaProducao_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        'Reposiciona UserControl
        Me.Top = (frmMain.picImage.Top + ((frmMain.picImage.Height - Me.Height) / 2))
        Me.Left = ((frmMain.picImage.Width - Me.Width) / 2)

    End Sub

    Private Sub btnConfirmar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirmar.Click

        Try

            'Pagar Requisição
            Call Confirmar()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcel.Click

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

            'Adiciona KeyUP
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrEstEntradaProducao_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Verifica Direito
            btnConfirmar.Enabled = VerificaDireito(Formulario.EstoqueEntradaProducao, gcInsert)

            'Carrega Combo - Grid
            Call LoadComboGrid(grdListagem, "deposito", "sp_select_combo_cadastro_basico_deposito " & goUsuario.iEmpresa)

            ConfiguraGrid(grdListagem, Formulario.EstoqueEntradaProducao)

            dtpDataEntrada.Value = Now

            'Seta Focu
            txtNumeroOrdemProducaoFiltro.Focus()

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

            'Carrega Controles
            oClsEstEntradaProducao.LoadGrid(grdListagem, _
                                            IIf(IsNumeric(txtNumeroOrdemProducaoFiltro.Text.Trim), txtNumeroOrdemProducaoFiltro.Text.Trim, -1), _
                                            txtCodigoProdutoFiltro.Text.Trim, _
                                            txtDescricaoFiltro.Text.Trim)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Confirmar()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Verifica se foi Selecionado algum valor válido
            If Validacao = True Then

                'Verifica se o Usuário deseja Aprovar a Requisição
                If MsgBox("Deseja dar Entrada do(s) Produtos(s) no Estoque?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    Dim sCodigoMovimentacao As String = ""

                    'Confirma Entrada do Produto em Estoque
                    sCodigoMovimentacao = oClsEstEntradaProducao.EntradaEstoque(dtpDataEntrada.Value)

                    'Verifica se ocorreu Movimentação no Estoque
                    If sCodigoMovimentacao <> "" Then

                        'Verifica se o Usuário deseja Imprimir Etiqueta
                        If MsgBox("Deseja Imprimir Etiqueta para os Produtos?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                            'Seta Cursor do Mouse
                            Cursor.Current = Cursors.WaitCursor

                            Dim oRptDocument As New ReportDocument

                            'Redimenciona Vetor
                            ReDim goCrystalReport.sReportParameter(1)
                            'Seta Parametros
                            goCrystalReport.sReportParameter(0).sParamenter = "@codigo_movimentacao"
                            goCrystalReport.sReportParameter(0).sValue = sCodigoMovimentacao
                            goCrystalReport.sReportParameter(1).sParamenter = "@codigo_empresa"
                            goCrystalReport.sReportParameter(1).sValue = goUsuario.iEmpresa
                            goCrystalReport.sReport = goCrystalReport.sPath & "EST000000005.rpt"

                            Dim oReport As New usrReport
                            oReport.Dock = DockStyle.Fill

                            'Abre Relatório
                            frmMain.LoadPageReport("EST000000005", "Etiqueta", oReport)

                            'Seta Cursor do Mouse
                            Cursor.Current = Cursors.Default

                        End If

                    End If

                    'Carrega Grid
                    Call LoadGrid()

                End If

            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function Validacao() As Boolean

        Try

            'Váriaveis Locais
            Dim i As Integer

            'Seta Retorno da Função
            Validacao = False

            If ValidacaoDataCusteio(dtpDataEntrada.Value) = False Then
                Exit Function
            End If

            If VerificaSelecaoRow(grdListagem) = True Then

                For i = 0 To UBound(gSelecaoRow)

                    If gSelecaoRow(i).Cells("quantidade_estoque").Value > gSelecaoRow(i).Cells("quantidade_produzida").Value Then
                        frmMain.Informacao(Mensagem.ValorInformadoNaoValido, "Quantidade Estoque")
                        Return False
                    End If

                    If IsDBNull(gSelecaoRow(i).Cells("deposito").Value) Then
                        frmMain.Informacao(Mensagem.NaoFoiInformado, "Depósito")
                        Return False
                    End If

                    'Não permite que seja dada entrada em OP com requisição em aberto
                    If oClsEstEntradaProducao.ValidaEstoque(gSelecaoRow(i).Cells("codigo_ordem_producao").Value) = False Then
                        frmMain.Informacao(Mensagem.OperacaoNaoRealizada, "A requisição da " + CStr(gSelecaoRow(i).Cells("numero_ordem_producao").Value) + " não foi paga.")
                        Return False
                    End If

                Next

            Else
                frmMain.Informacao(Mensagem.ValidacaoSelecionar)
                Return False
            End If

            'Seta Retorno da Função
            Validacao = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

End Class


