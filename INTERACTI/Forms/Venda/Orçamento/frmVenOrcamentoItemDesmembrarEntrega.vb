Imports Janus.Windows.GridEX
Imports Janus.Windows.CalendarCombo

Public Class frmVenOrcamentoItemDesmembrarEntrega

#Region "::: VARIAVEIS :::"

    'Variável da Classe
    Private sItem As String
    Private dQuantidade As Double
    Private oDataEntrega As Hashtable

#End Region

#Region "::: PROPERTIE :::"

    Public WriteOnly Property Item() As String
        Set(ByVal value As String)
            sItem = value
        End Set
    End Property

    Public WriteOnly Property Quantidade() As Double
        Set(ByVal value As Double)
            dQuantidade = value
        End Set
    End Property

    Public Property DataEntrega() As Hashtable
        Get
            Return oDataEntrega
        End Get
        Set(ByVal value As Hashtable)
            oDataEntrega = value
        End Set
    End Property

#End Region

#Region "::: CONTROLES :::"

    Private Sub frmVenOrcamentoItemDesmembrarEntrega_Load(sender As Object, e As EventArgs) Handles Me.Load

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

    Private Sub btnDesmembrarEntrega_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDesmembrarEntrega.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Formulário
            If Validacao() = True Then

                'Desmembra a Entrega
                Call DesmembrarEntrega()
                'Fecha o Formulário
                Me.Dispose()

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub GerarEntregas() Handles txtNumeroEntrega.ValueChanged, _
                                        txtIntervaloEntrega.ValueChanged

        Try

            'Caso Número de Entregas é maior do que 0
            If txtNumeroEntrega.Value > 0 Then

                'Variaveis Locais
                Dim dQuantidadeResidual As Double = txtQuantidade.Value
                Dim oDataSet As New DataSet
                Dim oDataTable As New DataTable
                Dim oDCPedidoVenda As New DataColumn("numero_pedido")
                Dim oDCDataEntrega As New DataColumn("prazo_entrega")
                Dim oDCQuantidade As New DataColumn("quantidade")
                Dim oDCQuantidadeFaturada As New DataColumn("quantidade_faturada")
                Dim oDCPrazoEntregaAntigo As New DataColumn("prazo_entrega_antigo")
                Dim oDCCodigo As New DataColumn("codigo")
                Dim dQuantidadeAuxiliar As Double
                Dim iContador As Integer = 0
                Dim dDataEntrega As Date = Now.Date

                'Seta DataType
                oDCPedidoVenda.DataType = "".GetType
                oDCDataEntrega.DataType = Now.Date.GetType
                oDCQuantidade.DataType = 0.0.GetType
                oDCQuantidadeFaturada.DataType = 0.0.GetType
                oDCPrazoEntregaAntigo.DataType = Now.Date.GetType
                oDCCodigo.DataType = 0.GetType

                'Adiciona Tabela ao DataSet
                oDataSet.Tables.Add(oDataTable)

                'Adiciona Colunas ao DataTable
                oDataTable.Columns.Add(oDCPedidoVenda)
                oDataTable.Columns.Add(oDCDataEntrega)
                oDataTable.Columns.Add(oDCQuantidade)
                oDataTable.Columns.Add(oDCQuantidadeFaturada)
                oDataTable.Columns.Add(oDCPrazoEntregaAntigo)
                oDataTable.Columns.Add(oDCCodigo)

                For Each oRow As GridEXRow In grdEntrega.GetDataRows

                    If oRow.Cells("numero_pedido").Value <> "" Then
                        Dim oDataRow As DataRow = oDataTable.NewRow
                        dDataEntrega = oRow.Cells("prazo_entrega").Value
                        oDataRow("numero_pedido") = oRow.Cells("numero_pedido").Value
                        oDataRow("prazo_entrega") = oRow.Cells("prazo_entrega").Value
                        oDataRow("quantidade") = oRow.Cells("quantidade").Value
                        oDataRow("quantidade_faturada") = oRow.Cells("quantidade_faturada").Value
                        oDataRow("prazo_entrega_antigo") = oRow.Cells("prazo_entrega_antigo").Value
                        oDataRow("codigo") = oRow.Cells("codigo").Value
                        dQuantidadeAuxiliar = dQuantidadeAuxiliar + oRow.Cells("quantidade").Value
                        oDataTable.Rows.Add(oDataRow)
                        iContador += 1
                    End If

                Next

                'Limpa Grid
                grdEntrega.DataSource = Nothing

                dQuantidadeResidual = dQuantidadeResidual - dQuantidadeAuxiliar

                'Adiciona Linhas ao DataTable
                For i = 1 To txtNumeroEntrega.Value - iContador
                    Dim oDataRow As DataRow = oDataTable.NewRow
                    oDataRow("prazo_entrega") = DateAdd(DateInterval.Day, (txtIntervaloEntrega.Value * (i)), dDataEntrega)
                    oDataRow("quantidade") = FormatNumber(IIf(i = (txtNumeroEntrega.Value - iContador), dQuantidadeResidual, (txtQuantidade.Value - dQuantidadeAuxiliar) / (txtNumeroEntrega.Value - iContador)), 4)
                    oDataRow("numero_pedido") = ""
                    oDataRow("quantidade_faturada") = 0
                    dQuantidadeResidual -= FormatNumber(IIf(i = (txtNumeroEntrega.Value - iContador), dQuantidadeResidual, (txtQuantidade.Value - dQuantidadeAuxiliar) / (txtNumeroEntrega.Value - iContador)), 4)
                    oDataTable.Rows.Add(oDataRow)
                Next

                'Configura DataMember
                Call ConfigurarDataMemberGrid(grdEntrega)

                'Carrega Grid
                grdEntrega.DataSource = oDataSet.DefaultViewManager
                grdEntrega.DataMember = oDataSet.Tables(0).TableName

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdEntrega_CellUpdated(sender As Object, e As ColumnActionEventArgs)

        Try

            If grdEntrega.CurrentRow.Cells("numero_pedido").Value <> "" AndAlso _
                (grdEntrega.CurrentRow.Cells("quantidade").Value <> grdEntrega.CurrentRow.Cells("quantidade_faturada").Value OrElse _
                 grdEntrega.CurrentRow.Cells("prazo_entrega").Value <> grdEntrega.CurrentRow.Cells("prazo_entrega_antigo").Value) Then
                UpdateRegistroGrid(grdEntrega, "(codigo = " & grdEntrega.CurrentRow.Cells("codigo").Value & ")", "quantidade", grdEntrega.CurrentRow.Cells("quantidade_faturada").Value)
                UpdateRegistroGrid(grdEntrega, "(codigo = " & grdEntrega.CurrentRow.Cells("codigo").Value & ")", "prazo_entrega", grdEntrega.CurrentRow.Cells("prazo_entrega_antigo").Value)
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
            txtItem.Text = sItem
            txtQuantidade.Value = dQuantidade

            'Seta Controle
            txtNumeroEntrega.Value = oDataEntrega.Count

            'Carrega Desmembramento
            Call LoadEntrega()

            'Seta Focu
            txtNumeroEntrega.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub DesmembrarEntrega()

        Try

            'Váriaveis
            Dim oPrevisaoEntrega As PrevisaoEntrega

            'Limpa Váriavel
            oDataEntrega.Clear()

            For Each oRow As GridEXRow In grdEntrega.GetDataRows
                oPrevisaoEntrega.sNotaFiscal = oRow.Cells("numero_pedido").Value
                oPrevisaoEntrega.sPrevisaoEntrega = oRow.Cells("prazo_entrega").Value
                oPrevisaoEntrega.dQuantidade = oRow.Cells("quantidade").Value
                oPrevisaoEntrega.dQuantidadeFaturada = oRow.Cells("quantidade_faturada").Value
                oPrevisaoEntrega.iCodigoEntrega = IIf(IsDBNull(oRow.Cells("codigo").Value), 0, oRow.Cells("codigo").Value)
                oDataEntrega.Add(oRow.RowIndex, oPrevisaoEntrega)
            Next

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub LoadEntrega()

        Try

            'Limpa Grid
            grdEntrega.DataSource = Nothing

            'Variaveis Locais
            Dim oDataSet As New DataSet
            Dim oDataTable As New DataTable
            Dim oDCNotaFiscal As New DataColumn("numero_pedido")
            Dim oDCDataEntrega As New DataColumn("prazo_entrega")
            Dim oDCQuantidade As New DataColumn("quantidade")
            Dim oDCQuantidadeFaturada As New DataColumn("quantidade_faturada")
            Dim oDCPrazoEntregaAntigo As New DataColumn("prazo_entrega_antigo")
            Dim oDCCodigo As New DataColumn("codigo")

            'Seta DataType
            oDCNotaFiscal.DataType = "".GetType
            oDCDataEntrega.DataType = Now.Date.GetType
            oDCQuantidade.DataType = 0.0.GetType
            oDCQuantidadeFaturada.DataType = 0.0.GetType
            oDCPrazoEntregaAntigo.DataType = Now.Date.GetType
            oDCCodigo.DataType = 0.GetType

            'Adiciona Tabela ao DataSet
            oDataSet.Tables.Add(oDataTable)

            'Adiciona Colunas ao DataTable
            oDataTable.Columns.Add(oDCNotaFiscal)
            oDataTable.Columns.Add(oDCDataEntrega)
            oDataTable.Columns.Add(oDCQuantidade)
            oDataTable.Columns.Add(oDCQuantidadeFaturada)
            oDataTable.Columns.Add(oDCPrazoEntregaAntigo)
            oDataTable.Columns.Add(oDCCodigo)

            'Adiciona Linhas ao DataTable
            For Each oPrevisaoEntrega As PrevisaoEntrega In oDataEntrega.Values
                Dim oDataRow As DataRow = oDataTable.NewRow
                oDataRow("numero_pedido") = oPrevisaoEntrega.sNotaFiscal
                oDataRow("prazo_entrega") = oPrevisaoEntrega.sPrevisaoEntrega
                oDataRow("quantidade") = oPrevisaoEntrega.dQuantidade
                oDataRow("quantidade_faturada") = oPrevisaoEntrega.dQuantidadeFaturada
                oDataRow("prazo_entrega_antigo") = oPrevisaoEntrega.sPrevisaoEntrega
                oDataRow("codigo") = oPrevisaoEntrega.iCodigoEntrega
                oDataTable.Rows.Add(oDataRow)
            Next

            'Configura DataMember
            Call ConfigurarDataMemberGrid(grdEntrega)

            'Carrega Grid
            grdEntrega.DataSource = oDataSet.DefaultViewManager
            grdEntrega.DataMember = oDataSet.Tables(0).TableName

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function Validacao() As Boolean

        Try

            'Seta Retorno da Função
            Validacao = False

            'Verifica se foi preenchido o Número de Entregas
            If ValidaCampo(txtNumeroEntrega, lblNumeroEntrega, True) = False Then
                Exit Function
            End If

            'Verifica se foi preenchido o Intervalo entre as Entregas
            If txtNumeroEntrega.Value > 1 Then
                If ValidaCampo(txtIntervaloEntrega, lblIntervaloEntrega, True) = False Then
                    Exit Function
                End If
            End If

            'Verifica se a Quantidade Total é igual a Quantidade das Entregas
            If txtQuantidade.Value <> grdEntrega.GetTotalRow.Cells("quantidade").Value Then
                frmMain.errInfo.SetError(lblQuantidade, "A Soma da Quantidade das Entregas é diferente da Quantidade Total. Favor verificar.")
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