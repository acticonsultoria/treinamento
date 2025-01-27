Imports Janus.Windows.GridEX
Imports Janus.Windows.CalendarCombo

Public Class frmVenPedidoEntregaDesmembrar

#Region "::: VARIAVEIS :::"

    'Variável da Classe
    Private oClsVenPedidoEntrega As New clsUsrVenPedidoEntrega
    Private lCodigoPedido As Long
    Private iCodigoPedidoItem As Integer
    Private iCodigoPedidoItemEntrega As Integer
    Private sDataEntrega As String
    Private sItem As String
    Private dQuantidade As Double

#End Region

#Region "::: PROPERTIE :::"

    Public WriteOnly Property CodigoPedido() As Long
        Set(ByVal value As Long)
            lCodigoPedido = value
        End Set
    End Property

    Public WriteOnly Property CodigoPedidoItem() As Integer
        Set(ByVal value As Integer)
            iCodigoPedidoItem = value
        End Set
    End Property

    Public WriteOnly Property CodigoPedidoItemEntrega() As Integer
        Set(ByVal value As Integer)
            iCodigoPedidoItemEntrega = value
        End Set
    End Property

    Public WriteOnly Property DataEntrega() As String
        Set(ByVal value As String)
            sDataEntrega = value
        End Set
    End Property

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

#End Region

#Region "::: CONTROLES :::"

    Private Sub frmVenPedidoEntregaDesmembrar_Load(sender As Object, e As EventArgs) Handles Me.Load

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

            'Limpa Grid
            grdEntrega.DataSource = Nothing

            'Caso Número de Entregas é maior do que 0
            If txtNumeroEntrega.Value > 0 Then

                'Variaveis Locais
                Dim dQuantidadeResidual As Double = txtQuantidade.Value
                Dim oDataSet As New DataSet
                Dim oDataTable As New DataTable
                Dim oDCPrazoEntrega As New DataColumn("prazo_entrega")
                Dim oDCQuantidade As New DataColumn("quantidade")

                'Seta DataType
                oDCPrazoEntrega.DataType = Now.Date.GetType
                oDCQuantidade.DataType = 0.0.GetType

                'Adiciona Tabela ao DataSet
                oDataSet.Tables.Add(oDataTable)

                'Adiciona Colunas ao DataTable
                oDataTable.Columns.Add(oDCPrazoEntrega)
                oDataTable.Columns.Add(oDCQuantidade)

                'Adiciona Linhas ao DataTable
                For i = 1 To txtNumeroEntrega.Value
                    Dim oDataRow As DataRow = oDataTable.NewRow
                    oDataRow("prazo_entrega") = DateAdd(DateInterval.Day, (txtIntervaloEntrega.Value * (i)), Now.Date)
                    oDataRow("quantidade") = FormatNumber(IIf(i = txtNumeroEntrega.Value, dQuantidadeResidual, txtQuantidade.Value / txtNumeroEntrega.Value), 4)
                    dQuantidadeResidual -= FormatNumber(txtQuantidade.Value / txtNumeroEntrega.Value, 4)
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
            txtNumeroEntrega.Value = 1

            'Carrega Desmembramento
            Call LoadEntrega(sDataEntrega, dQuantidade)

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

            'Desmembra Entrega
            Call oClsVenPedidoEntrega.DesmembrarEntrega(grdEntrega, _
                                                        lCodigoPedido, _
                                                        iCodigoPedidoItem, _
                                                        iCodigoPedidoItemEntrega, _
                                                        dQuantidade)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub LoadEntrega(ByVal sDataEntrega As String, _
                            ByVal sQuantidadeEntrega As String)

        Try

            'Limpa Grid
            grdEntrega.DataSource = Nothing

            'Variaveis Locais
            Dim oDataSet As New DataSet
            Dim oDataTable As New DataTable
            Dim oDCDataEntrega As New DataColumn("prazo_entrega")
            Dim oDCQuantidade As New DataColumn("quantidade")

            'Seta DataType
            oDCDataEntrega.DataType = Now.Date.GetType
            oDCQuantidade.DataType = 0.0.GetType

            'Adiciona Tabela ao DataSet
            oDataSet.Tables.Add(oDataTable)

            'Adiciona Colunas ao DataTable
            oDataTable.Columns.Add(oDCDataEntrega)
            oDataTable.Columns.Add(oDCQuantidade)

            'Adiciona Linhas ao DataTable
            Dim oDataRow As DataRow = oDataTable.NewRow
            oDataRow("prazo_entrega") = sDataEntrega
            oDataRow("quantidade") = dQuantidade
            oDataTable.Rows.Add(oDataRow)
            
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