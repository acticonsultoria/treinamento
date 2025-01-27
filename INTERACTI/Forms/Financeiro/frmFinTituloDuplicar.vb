Imports Janus.Windows.GridEX

Public Class frmFinTituloDuplicar

#Region "::: VARIAVEIS :::"

    'Variável da Classe
    Private oClsFrmFinTituloDuplicar As New clsFrmFinTituloDuplicar
    Private oGrid As GridEX
    Private sTipo As String

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

    Public Property Tipo() As String
        Get
            Return sTipo
        End Get
        Set(ByVal value As String)
            sTipo = value
        End Set
    End Property

#End Region

#Region "::: CONTROLES :::"

    Private Sub frmFinTituloDuplicar_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura Formulário
        Call ConfigurarFormulario()

    End Sub

    Private Sub frmFinTituloDuplicar_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        'Reposiciona Formulário
        Me.Top = (frmMain.picImage.Top + ((frmMain.picImage.Height - Me.Height) / 2))
        Me.Left = ((frmMain.picImage.Width - Me.Width) / 2)

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

    Private Sub btnDuplicar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDuplicar.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Formulário
            If Validacao() = True Then

                'Cancela o Título
                DuplicarTitulo()

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub GerarReceita() Handles txtNumeroTitulos.ValueChanged, _
                                       txtIntervaloEntreTitulos.ValueChanged, _
                                       cboTipoIntervalo.SelectedIndexChanged, _
                                       dtpDataBase.ValueChanged

        Try

            'Verifica se foi Selecionado o Tipo de Intervalo
            If cboTipoIntervalo.SelectedIndex = -1 Then
                Exit Sub
            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Carrega Grid
            Call LoadGrid(grdTitulo, _
                          IIf(IsDBNull(oGrid.CurrentRow.Cells("serie").Value), "", oGrid.CurrentRow.Cells("serie").Value), _
                          dtpDataBase.Value, _
                          oGrid.CurrentRow.Cells("valor").Value, _
                          IIf(oGrid.CurrentRow.Cells("tipo_titulo_financeiro").Value = "REAL", TipoTituloFinanceiro.Real, TipoTituloFinanceiro.Previsto), _
                          txtNumeroTitulos.Value)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

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

            'Carrega Combo
            Call LoadComboGrid(grdTitulo, "tipo_titulo_financeiro", "sp_select_combo_static_tipo_titulo_financeiro")

            'Seta Controle
            txtNumeroDocumento.Text = oGrid.CurrentRow.Cells("numero_documento").Value
            txtParceiroNegocio.Text = oGrid.CurrentRow.Cells("parceiro_negocio").Value
            lblParceiroNegocio.Text = IIf(sTipo = "R", "Cliente:", "Fornecedor:")

            'Carrega Combo - Tipo
            cboTipoIntervalo.Items.Clear()
            cboTipoIntervalo.Items.Add("DIA", "D")
            'cboTipoIntervalo.Items.Add("MÊS", "M")
            cboTipoIntervalo.Items.Add("MÊS", "MF")
            cboTipoIntervalo.Items.Add("ANO", "A")
            cboTipoIntervalo.SelectedValue = "D"
            dtpDataBase.Value = Now
            'Seta Focu
            txtNumeroTitulos.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub DuplicarTitulo()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            If MsgBox("Deseja Duplicar o Registro Selecionado?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes Then

                'Duplica Receita
                oClsFrmFinTituloDuplicar.Duplicar(oGrid.CurrentRow.Cells("codigo_titulo_capa").Value, _
                                                  grdTitulo)

                'Informa o Usuário sobre o Sucesso da Operação
                frmMain.Informacao(Mensagem.OperacaoRealizadaSucesso)

                'Fecha o Formulário
                Me.Dispose()

            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGrid(ByVal oGrid As GridEX, _
                        ByVal sSerie As String, _
                        ByVal dDataEmissao As Date, _
                        ByVal dValor As Double, _
                        ByVal iTipoTituloFinanceiro As Integer, _
                        ByVal iNumeroReceita As Integer)

        Try

            'Limpa Grid
            oGrid.DataSource = Nothing

            'Caso Valor Liquido maior que 0
            If iNumeroReceita > 0 Then

                'Variaveis Locais
                Dim oDataSet As New DataSet
                Dim oDataTable As New DataTable
                Dim oDCNumeroDocumento As New DataColumn("numero_documento")
                Dim oDCSerie As New DataColumn("serie")
                Dim oDCDataEmissao As New DataColumn("data_emissao")
                Dim oDCDataVencimento As New DataColumn("data_vencimento")
                Dim oDCValor As New DataColumn("valor")
                Dim oDCTipoTituloFinanceiro As New DataColumn("tipo_titulo_financeiro")
                Dim oDCNumeroDias As New DataColumn("numero_dias")

                'Seta DataType
                oDCDataEmissao.DataType = Now.Date.GetType
                oDCValor.DataType = 0.0.GetType

                'Adiciona Tabela ao DataSet
                oDataSet.Tables.Add(oDataTable)

                'Adiciona Colunas ao DataTable
                oDataTable.Columns.Add(oDCNumeroDocumento)
                oDataTable.Columns.Add(oDCSerie)
                oDataTable.Columns.Add(oDCDataVencimento)
                oDataTable.Columns.Add(oDCDataEmissao)
                oDataTable.Columns.Add(oDCValor)
                oDataTable.Columns.Add(oDCTipoTituloFinanceiro)
                oDataTable.Columns.Add(oDCNumeroDias)

                'Adiciona Linhas ao DataTable
                For i = 1 To iNumeroReceita
                    Dim oDataRow As DataRow = oDataTable.NewRow
                    oDataRow("numero_documento") = txtNumeroDocumento.Text & "-" & Format(i, "00")
                    oDataRow("serie") = sSerie
                    Select Case cboTipoIntervalo.SelectedValue
                        Case "D" : oDataRow("data_emissao") = DateAdd(DateInterval.Day, (txtIntervaloEntreTitulos.Value * (i - 1)), dDataEmissao)
                        Case "M" : oDataRow("data_emissao") = DateAdd(DateInterval.Month, (txtIntervaloEntreTitulos.Value * (i - 1)), dDataEmissao)
                        Case "MF" : oDataRow("data_emissao") = DateAdd(DateInterval.Day, DatePart(DateInterval.Day, dDataEmissao) - DatePart(DateInterval.Day, DateAdd(DateInterval.Month, (txtIntervaloEntreTitulos.Value * (i - 1)), dDataEmissao)), DateAdd(DateInterval.Month, (txtIntervaloEntreTitulos.Value * (i - 1)), dDataEmissao))
                        Case "S" : oDataRow("data_emissao") = DateAdd(DateInterval.Month, (txtIntervaloEntreTitulos.Value * (i - 1)) * 6, dDataEmissao)
                        Case "A" : oDataRow("data_emissao") = DateAdd(DateInterval.Year, (txtIntervaloEntreTitulos.Value * (i - 1)), dDataEmissao)
                    End Select
                    oDataRow("valor") = dValor
                    oDataRow("tipo_titulo_financeiro") = iTipoTituloFinanceiro
                    oDataRow("numero_dias") = (txtIntervaloEntreTitulos.Value * (i - 1))
                    oDataRow("data_vencimento") = oDataRow("data_emissao")
                    oDataTable.Rows.Add(oDataRow)
                Next

                With oGrid

                    ConfigurarDataMemberGrid(oGrid)

                    .DataSource = oDataSet.DefaultViewManager
                    .DataMember = oDataSet.Tables(0).TableName

                End With

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function Validacao() As Boolean

        Try

            'Seta Retorno da Função
            Validacao = False

            'Verifica se foi preenchido o Número de Receitas
            If ValidaCampo(txtNumeroTitulos, lblNumeroTitulos, True) = False Then
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