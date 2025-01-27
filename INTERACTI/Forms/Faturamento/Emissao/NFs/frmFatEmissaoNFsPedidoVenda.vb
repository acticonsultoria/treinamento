Imports Janus.Windows.GridEX

Public Class frmFatEmissaoNFsPedidoVenda

#Region "::: VÁRIAVEIS :::"

    Private oClsFatEmissaoNFsPedidoVenda As New clsFrmFatEmissaoNFsPedidoVenda
    Private oUsrFatEmissaoNFs As usrFatEmissaoNFs
    Private dAliquotaISS As Double
    Private bISSRetido As Boolean    
    Private dAliquotaPIS As Double
    Private dAliquotaCOFINS As Double
    Private dAliquotaINSS As Double
    Private dAliquotaCSLL As Double
    Private dAliquotaIR As Double
    Private dDesconto As Double
    Private dValorFinal As Double
    Private sFormaPagamento As String
    Private iCodigoCondicaoPagamento As Integer
    Private iIntervaloEntreParcelas As Integer
    Private iDiaCobranca As Integer
    Private iNumeroParcela As Integer
    Private iCodigoCentroCusto As Integer
    Private sCodigoContaContabil As String
    Private lCodigoItem As Long

#End Region

#Region "::: PROPERTIE :::"

    Public Property usrEmissaoNFs() As UserControl
        Get
            Return oUsrFatEmissaoNFs
        End Get
        Set(ByVal value As UserControl)
            oUsrFatEmissaoNFs = value
        End Set
    End Property

#End Region

#Region "::: CONTROLES :::"

    Private Sub frmFatEmissaoNFsPedidoVenda_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'Configura Formulário
        Call ConfigurarFormulario()

    End Sub

    'Private Sub frmFatEmissaoNFsPedidoVenda_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

    '    'Reposiciona Formulário
    '    Me.Top = (frmMain.tabMain.Top + ((frmMain.tabMain.Height - Me.Height) / 2) + gcFormAjust)
    '    Me.Left = (frmMain.tabMain.Left + ((frmMain.tabMain.Width - Me.Width) / 2))

    'End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click

        'Fecha o Controle
        Me.Dispose()

    End Sub

    Private Sub btnImportarPedidoVenda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImportarPedidoVenda.Click

        Try

            'Valida Dados do Formulário
            If Validacao() = True Then

                Dim sMensagem As String = "Ficam reduzida a zero as Alíq. De PIS/COFINS, Conform. Lei 5171/2004, Art 6º."

                'Importar Pedido de Venda
                oUsrFatEmissaoNFs.cboTomador.SelectedValue = txtCliente.Tag
                oUsrFatEmissaoNFs.cboServico.SelectedValue = lCodigoItem
                oUsrFatEmissaoNFs.txtDescricao.Text = txtDescricao.Text + vbCrLf + vbCrLf + sMensagem
                oUsrFatEmissaoNFs.txtValorServico.Value = txtValorServico.Value
                oUsrFatEmissaoNFs.txtValorDescontoIncondicionado.Value = 0
                oUsrFatEmissaoNFs.txtAliquotaISS.Value = dAliquotaISS
                oUsrFatEmissaoNFs.cboISSRetido.SelectedValue = bISSRetido
                oUsrFatEmissaoNFs.txtAliquotaPIS.Value = dAliquotaPIS
                oUsrFatEmissaoNFs.txtAliquotaCOFINS.Value = dAliquotaCOFINS
                oUsrFatEmissaoNFs.txtAliquotaINSS.Value = dAliquotaINSS
                oUsrFatEmissaoNFs.txtAliquotaCSLL.Value = dAliquotaCSLL
                oUsrFatEmissaoNFs.txtAliquotaIR.Value = dAliquotaIR
                oUsrFatEmissaoNFs.txtFatura.Text = sFormaPagamento
                oUsrFatEmissaoNFs.txtValorDescontoIncondicionado.Text = dDesconto
                oUsrFatEmissaoNFs.txtIntervaloEntreParcelas.Value = iIntervaloEntreParcelas
                oUsrFatEmissaoNFs.txtNumeroParcela.Value = iNumeroParcela
                oUsrFatEmissaoNFs.txtValorLiquidoNFSE.Value = dValorFinal

                If sCodigoContaContabil = "" Then
                    oUsrFatEmissaoNFs.cboContaContabil.SelectedIndex = -1
                Else
                    oUsrFatEmissaoNFs.cboContaContabil.SelectedValue = sCodigoContaContabil
                End If

                oUsrFatEmissaoNFs.cboServico.Tag = cboPedidoVenda.SelectedValue.ToString & "/" & cboServico.SelectedValue.ToString & "/" & txtValorServico.Value.ToString.Replace(".", ",")

                'Gera Duplicata
                Call oUsrFatEmissaoNFs.btnCalcularDuplicata_Click(oUsrFatEmissaoNFs.btnCalcularDuplicata, System.EventArgs.Empty)

                'Fecha Formulário
                Me.Dispose()

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub cboPedidoVenda_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPedidoVenda.SelectedIndexChanged

        Try

            'Verifica se foi Selecionado algum Pedido de Venda
            If cboPedidoVenda.SelectedIndex = -1 Then
                'Limpa Controles
                txtCliente.Text = ""
                txtCliente.Tag = ""
                txtCNPJCPF.Text = ""
                cboServico.DataSource = Nothing : cboServico.Text = ""
            Else
                'Carrega Controles
                Call oClsFatEmissaoNFsPedidoVenda.LoadDadosPedidoVenda(cboPedidoVenda.SelectedValue, _
                                                                       txtCliente, _
                                                                       txtCNPJCPF)
                'Carrega Combo - Serviço
                Call LoadCombo(cboServico, "sp_select_combo_faturamento_emissao_nfse_pedido_venda_servico " & cboPedidoVenda.SelectedValue & ", " & CInt(TipoItem.servico) & ", " & goUsuario.iEmpresa, False)
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub cboServico_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboServico.SelectedIndexChanged

        Try

            'Verifica se foi Selecionado algum Pedido de Venda
            If cboServico.SelectedIndex = -1 Then

                'Limpa Controles
                txtDescricao.Text = ""
                txtValorServico.Value = 0
                txtValorServicoPendente.Value = 0
                txtCentroCusto.Text = ""
                txtContaContabil.Text = ""
                dAliquotaISS = 0
                bISSRetido = False
                dAliquotaPIS = 0
                dAliquotaCOFINS = 0
                dAliquotaINSS = 0
                dAliquotaCSLL = 0
                dAliquotaIR = 0
                dValorFinal = 0
                dDesconto = 0
                sFormaPagamento = ""
                iCodigoCondicaoPagamento = -1
                iIntervaloEntreParcelas = 0
                iDiaCobranca = 0
                iNumeroParcela = 0
                iCodigoCentroCusto = -1
                sCodigoContaContabil = ""
                lCodigoItem = -1

            Else

                'Carrega Controles
                Call oClsFatEmissaoNFsPedidoVenda.LoadDadosPedidoVendaServico(cboPedidoVenda.SelectedValue, _
                                                                              cboServico.SelectedValue, _
                                                                              txtDescricao, _
                                                                              txtValorServico, _
                                                                              txtValorServicoPendente, _
                                                                              txtCentroCusto, _
                                                                              txtContaContabil, _
                                                                              dAliquotaISS, _
                                                                              bISSRetido, _
                                                                              dAliquotaPIS, _
                                                                              dAliquotaCOFINS, _
                                                                              dAliquotaINSS, _
                                                                              dAliquotaCSLL, _
                                                                              dAliquotaIR, _
                                                                              sFormaPagamento, _
                                                                              iCodigoCondicaoPagamento, _
                                                                              iIntervaloEntreParcelas, _
                                                                              iNumeroParcela, _
                                                                              iCodigoCentroCusto, _
                                                                              sCodigoContaContabil, _
                                                                              lCodigoItem)
                
            End If

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

            'Carrega Combo de Cliente
            Call LoadCombo(cboPedidoVenda, "sp_select_combo_faturamento_nfse_pedido_venda " & goUsuario.iEmpresa & ", " & CInt(TipoItem.servico), False)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Function Validacao() As Boolean

        Dim iPedido As Integer
        Dim bTipoItem As Boolean

        iPedido = cboPedidoVenda.SelectedValue

        Try

            'Seta Retorno da Função
            Validacao = False

            'Verifica se foi Selecionado o Campo - Pedido de Venda
            If ValidaCampo(cboPedidoVenda, lblPedidoVenda) = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Serviço
            If ValidaCampo(cboServico, lblServico) = False Then
                Exit Function
            End If

            'Verifica se o Valor da Nota é maior que o Valor do Pedido
            If txtValorServicoPendente.Value < txtValorServico.Value Then
                frmMain.errInfo.SetError(lblValorServico, "O Valor do Serviço não pode ser maior que o Valor Pendente.")
                txtValorServico.Focus()
                Exit Function
            End If

            bTipoItem = oClsFatEmissaoNFsPedidoVenda.ValidaTipoItem(iPedido)
            If bTipoItem = False Then

                If MsgBox("Você está importando um item que foi orçado como produto, deseja continuar?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then

                    Exit Function

                End If

            End If

            'Seta Retorno da Função
            Validacao = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

End Class