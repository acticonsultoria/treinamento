Imports Janus.Windows.GridEX

Public Class frmFatEmissaoNFeRetornoMaterialTerceiro

#Region "::: VARIAVEIS :::"

    'Variável da Classe
    Private oClsFatEmissaoNFeRetornoMaterialTerceiro As New clsFrmFatEmissaoNFeRetornoMaterialTerceiro
    Private lCodigoEmissaoCapa As Long

#End Region

#Region "::: PROPERTIE :::"

    Public Property CodigoEmissaoCapa() As Long
        Get
            Return lCodigoEmissaoCapa
        End Get
        Set(ByVal value As Long)
            lCodigoEmissaoCapa = value
        End Set
    End Property

#End Region

#Region "::: CONTROLES :::"

    Private Sub frmFatEmissaoNFeRetornoMaterialTerceiro_KeyDown(sender As Object, e As KeyEventArgs) 

        Try

            Select Case e.KeyCode

                Case Keys.Enter 
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGrid Else Control_Enter(sender)
                    
            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub frmFatEmissaoNFeRetornoMaterialTerceiro_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura Formulário
        Call ConfigurarFormulario()

    End Sub

    Private Sub frmFatEmissaoNFeRetornoMaterialTerceiro_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        Me.Top = (frmMain.picImage.Top + ((frmMain.picImage.Height - Me.Height) / 2))
        Me.Left = ((frmMain.picImage.Width - Me.Width) / 2)

    End Sub

    Private Sub btnConfigurarGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGrid.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdRetornoTerceiro
            oForm.NomeFormulario = Formulario.FaturamentoEmissaoNFe
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdRetornoTerceiro, Formulario.FaturamentoEmissaoNFe)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltrar.Click

        Try

            'Verifica se foi Selecionado o Campo - Cliente
            If ValidaCampo(cboClienteFiltro, lblClienteFiltro) = False Then
                Exit Sub
            End If

            'Carrega Grid
            Call LoadGrid()

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

    Private Sub btnRetornoMercadoria_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRetornoMercadoria.Click

        Try

            'Valida Dados do Formulário
            If Validacao() = True Then

                'Retorna Mercadoria
                Call RetornoMercadoriaTerceiro()

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdRetornoTerceiro_CellValueChanged(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdRetornoTerceiro.CellValueChanged

        Try

            Select Case grdRetornoTerceiro.CurrentColumn.Key

                Case "quantidade_retorno"

                    'Verifica se a Quantidade é Válida
                    If IsNumeric(grdRetornoTerceiro.GetValue("quantidade_retorno")) = False Then Exit Sub

                    Dim dQuantidade As Double = grdRetornoTerceiro.GetValue("quantidade")
                    Dim dQuantidadeRetorno As Double = grdRetornoTerceiro.GetValue("quantidade_retorno")
                    Dim dValorUnitario As Double = grdRetornoTerceiro.GetValue("valor_unitario")
                    If dQuantidade < dQuantidadeRetorno Then
                        grdRetornoTerceiro.SetValue("quantidade_retorno", dQuantidade)
                    Else
                        grdRetornoTerceiro.SetValue("valor_total", dValorUnitario * dQuantidadeRetorno)
                    End If

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdRetornoTerceiro_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdRetornoTerceiro.RowDoubleClick

        Try

            'Verifica se a Linha Pressionada é Válida
            If IsNothing(grdRetornoTerceiro.CurrentColumn) Then Exit Sub

            Select Case grdRetornoTerceiro.CurrentColumn.Key

                Case "regra_venda" : Call CadastrarRegraVenda()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdRetornoTerceiro_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdRetornoTerceiro.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdRetornoTerceiro, _
                                     Formulario.FaturamentoEmissaoNFe)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdRetornoTerceiro_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdRetornoTerceiro.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdRetornoTerceiro.Name, _
                                     Formulario.FaturamentoEmissaoNFe, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

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
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf frmFatEmissaoNFeRetornoMaterialTerceiro_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Carrega Combo
            Call LoadCombo(cboClienteFiltro, "sp_select_combo_faturamento_cliente_retorno_material " & goUsuario.iEmpresa, False)
            Call LoadCombo(cboDepositoFiltro, "sp_select_combo_cadastro_basico_deposito_terceiro " & goUsuario.iEmpresa, False)

            'Seta CalendarCombo
            dtpDataEmissaoInicioFiltro.Value = Now.Date : dtpDataEmissaoInicioFiltro.Checked = False
            dtpDataEmissaoTerminoFiltro.Value = Now.Date : dtpDataEmissaoTerminoFiltro.Checked = False
            dtpDataEntradaInicioFiltro.Value = Now.Date : dtpDataEntradaInicioFiltro.Checked = False
            dtpDataEntradaTerminoFiltro.Value = Now.Date : dtpDataEntradaTerminoFiltro.Checked = False

            'Configura Grid
            Call ConfiguraGrid(grdRetornoTerceiro, Formulario.FaturamentoEmissaoNFe)

            'Seta Focu
            cboClienteFiltro.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub CadastrarRegraVenda()

        Try

            'Carrega Váriaveis
            Dim oFormularioCadastroBasico(3) As FormularioCadastroBasico

            oFormularioCadastroBasico(0).oValor = CInt(TipoRegraImposto.RetornoMaterialIndustrializado) : oFormularioCadastroBasico(0).sControle = "cboTipoRegra"
            oFormularioCadastroBasico(1).oValor = grdRetornoTerceiro.CurrentRow.Cells("codigo_personalidade").Value : oFormularioCadastroBasico(1).sControle = "cboPersonalidade"
            oFormularioCadastroBasico(2).oValor = grdRetornoTerceiro.CurrentRow.Cells("uf_destino").Value : oFormularioCadastroBasico(2).sControle = "cboUFDestino"
            oFormularioCadastroBasico(3).oValor = grdRetornoTerceiro.CurrentRow.Cells("codigo_deposito").Value : oFormularioCadastroBasico(3).sControle = "cboDeposito"

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrImpRegra"
            oForm.Size = frmMain.tlpMain.Size : oForm.Location = frmMain.tlpMain.Location: oForm.Tamanho = True
            oForm.CadastroBasico = oFormularioCadastroBasico
            oForm.Titulo = Me.Text
            'Abre o Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Recarrega a Grid
            Call LoadGrid()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub RetornoMercadoriaTerceiro()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Retorno de Mercadoria de Terceiros
            oClsFatEmissaoNFeRetornoMaterialTerceiro.RetornoMercadoriaTerceiro(lCodigoEmissaoCapa, _
                                                                               cboClienteFiltro.SelectedValue, _
                                                                               grdRetornoTerceiro)


            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

            'Informa o Usuário sobre o Sucesso da Operação
            frmMain.Informacao(Mensagem.OperacaoRealizadaSucesso)

            'Fecha o Formulário
            Me.Dispose()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub LoadGrid()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Carrega Grid de Retorno de Material de Terceiro
            oClsFatEmissaoNFeRetornoMaterialTerceiro.LoadGrid(grdRetornoTerceiro, _
                                                              IIf(cboClienteFiltro.SelectedIndex = -1, -1, cboClienteFiltro.SelectedValue), _
                                                              IIf(cboDepositoFiltro.SelectedIndex = -1, -1, cboDepositoFiltro.SelectedValue), _
                                                              IIf(dtpDataEmissaoInicioFiltro.Checked = False, "", dtpDataEmissaoInicioFiltro.Value), _
                                                              IIf(dtpDataEmissaoTerminoFiltro.Checked = False, "", dtpDataEmissaoTerminoFiltro.Value), _
                                                              txtCodigoProdutoFiltro.Text.Trim, _
                                                              IIf(IsNumeric(txtNotaFiscalFiltro.Text.Trim), txtNotaFiscalFiltro.Text.Trim, -1), _
                                                              IIf(dtpDataEntradaInicioFiltro.Checked = False, "", dtpDataEntradaInicioFiltro.Value), _
                                                              IIf(dtpDataEntradaTerminoFiltro.Checked = False, "", dtpDataEntradaTerminoFiltro.Value))

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function Validacao() As Boolean

        Try

            'Verifica se foi Selecionado algum Orçamento
            For Each oRow As GridEXRow In grdRetornoTerceiro.GetDataRows

                'Verifica se o Registro é Válido
                If IsDBNull(oRow.Cells("codigo_regra_imposto").Value) = False AndAlso _
                   oRow.Cells("quantidade_retorno").Value > 0 AndAlso _
                   oRow.Cells("quantidade_retorno").Value <= oRow.Cells("quantidade").Value Then

                    'Seta Retorno da Função
                    Return True

                End If

            Next

            'Informa o Usuário sobre a Necessidade de Selecionar um Registro
            frmMain.Informacao(Mensagem.ValidacaoSelecionar)

            'Seta Retorno da Função
            Return False

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

End Class