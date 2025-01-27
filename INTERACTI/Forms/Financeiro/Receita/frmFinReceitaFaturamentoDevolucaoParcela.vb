Imports Janus.Windows.GridEX
Imports Janus.Windows.CalendarCombo

Public Class frmFinReceitaFaturamentoDevolucaoParcela

#Region "::: VARIAVEIS :::"

    'Variável da Classe
    Private sNumeroDocumento As String
    Private sDataEmissao As String
    Private sDescritivo As String    
    Private dValor As Double
    Private lCodigoTituloCapa As Long

#End Region

#Region "::: PROPERTIE :::"

    Public WriteOnly Property NumeroDocumento() As String
        Set(ByVal value As String)
            sNumeroDocumento = value
        End Set
    End Property

    Public WriteOnly Property DataEmissao() As String
        Set(ByVal value As String)
            sDataEmissao = value
        End Set
    End Property

    Public WriteOnly Property Descritivo() As String
        Set(ByVal value As String)
            sDescritivo = value
        End Set
    End Property

    Public WriteOnly Property Valor() As Double
        Set(ByVal value As Double)
            dValor = value
        End Set
    End Property

    Public WriteOnly Property CodigoTituloCapa() As Long
        Set(ByVal value As Long)
            lCodigoTituloCapa = value
        End Set
    End Property

#End Region

#Region "::: CONTROLES :::"

    Private Sub frmFinReceitaFaturamentoDevolucaoParcela_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura Formulário
        Call ConfigurarFormulario()

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

    Private Sub btnGerarCredito_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGerarCredito.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Formulário
            If Validacao() = True Then

                'Desmembra a Parcela
                Call GerarCredito()

                'Informa o Usuário sobre o Sucesso da Operação
                frmMain.Informacao(Mensagem.OperacaoRealizadaSucesso)

                'Fecha o Formulário
                Me.Dispose()

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub GerarParcelas() Handles txtNumeroParcelas.ValueChanged, _
                                        txtIntervaloParcelas.ValueChanged

        Try

            'Limpa Grid
            grdParcela.DataSource = Nothing

            'Caso Número de Entregas é maior do que 0
            If txtNumeroParcelas.Value > 0 Then

                'Variaveis Locais
                Dim dValorResidual As Double = txtValor.Value
                Dim oDataSet As New DataSet
                Dim oDataTable As New DataTable
                Dim oDCDataVencimento As New DataColumn("data_vencimento")
                Dim oDCValor As New DataColumn("valor")

                'Seta DataType
                oDCDataVencimento.DataType = Now.Date.GetType
                oDCValor.DataType = 0.0.GetType

                'Adiciona Tabela ao DataSet
                oDataSet.Tables.Add(oDataTable)

                'Adiciona Colunas ao DataTable
                oDataTable.Columns.Add(oDCDataVencimento)
                oDataTable.Columns.Add(oDCValor)

                'Adiciona Linhas ao DataTable
                For i = 1 To txtNumeroParcelas.Value
                    Dim oDataRow As DataRow = oDataTable.NewRow
                    oDataRow("data_vencimento") = DateAdd(DateInterval.Day, (txtIntervaloParcelas.Value * (i - 1)), CDate(sDataEmissao))
                    oDataRow("valor") = FormatNumber(IIf(i = txtNumeroParcelas.Value, dValorResidual, txtValor.Value / txtNumeroParcelas.Value), 2)
                    dValorResidual -= FormatNumber(txtValor.Value / txtNumeroParcelas.Value, 2)
                    oDataTable.Rows.Add(oDataRow)
                Next

                'Configura DataMember
                Call ConfigurarDataMemberGrid(grdParcela)

                'Carrega Grid
                grdParcela.DataSource = oDataSet.DefaultViewManager
                grdParcela.DataMember = oDataSet.Tables(0).TableName

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

            'Seta Ícone
            Me.Icon = frmMain.Icon

            'Seta Controle
            txtNumeroDocumento.Text = sNumeroDocumento
            txtDescritivo.Text = sDescritivo
            txtValor.Value = dValor
            txtNumeroParcelas.Value = 1
            txtIntervaloParcelas.Value = 0

            'Gera Parcelas
            Call GerarParcelas()

            'Seta Focu
            txtNumeroParcelas.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub GerarCredito()

        Try

            'Váriaveis Locais
            Dim oClsFinReceitaFaturamentoDevolucao As New clsUsrFinReceitaFaturamentoDevolucao

            'Verifica se o Usuário deseja Cancelar o Título
            If MsgBox("Deseja Gerar um Crédito de: " & dValor & " para o Título Financeiro referente a Nota Fiscal: " & sNumeroDocumento & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

                'Váriaveis
                Dim lCodigo As Long

                'Gerar Crédito
                Call oClsFinReceitaFaturamentoDevolucao.GerarCreditoTitulo(lCodigoTituloCapa, _
                                                                           sNumeroDocumento, _
                                                                           sDataEmissao, _
                                                                           dValor, _
                                                                           lCodigo)

                'Insere Parcelas
                Call oClsFinReceitaFaturamentoDevolucao.GerarCreditoParcela(lCodigo, _
                                                                            grdParcela)

                'Informa o Usuário sobre o Sucesso da Operação
                frmMain.Informacao(Mensagem.OperacaoRealizadaSucesso)

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function Validacao() As Boolean

        Try

            'Seta Retorno da Função
            Validacao = False

            'Verifica se foi preenchido o Número de Entregas
            If ValidaCampo(txtNumeroParcelas, lblNumeroParcelas, True) = False Then
                Exit Function
            End If

            'Verifica se foi preenchido o Intervalo entre as Entregas
            If txtNumeroParcelas.Value > 1 Then
                If ValidaCampo(txtIntervaloParcelas, lblIntervaloParcelas, True) = False Then
                    Exit Function
                End If
            End If

            'Verifica se a Quantidade Total é igual a Quantidade das Entregas
            If txtValor.Value <> grdParcela.GetTotalRow.Cells("valor").Value Then
                frmMain.errInfo.SetError(lblValor, "A Soma dos Valores das Parcelas é diferente do Valor Original da Parcela. Favor verificar.")
                Exit Function
            End If

            'Seta Retorno da Função
            Validacao = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

End Class