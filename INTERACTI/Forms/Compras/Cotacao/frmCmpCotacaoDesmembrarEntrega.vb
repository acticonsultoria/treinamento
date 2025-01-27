Imports Janus.Windows.GridEX
Imports Janus.Windows.CalendarCombo

Public Class frmCmpCotacaoDesmembrarEntrega

#Region "::: VARIAVEIS :::"

    'Variáveis - Controles
    Private oDtpDataEntrega As CalendarCombo
    Private sItem As String
    Private dQuantidade As Double

    'Váriaveis - Salvar
    Private sDataEntrega As String
    Private lCodigoCotacao As Long
    Private iCodigoCotacaoFornecedor As Integer
    Private iCodigoCotacaoItem As Integer    

#End Region

#Region "::: PROPERTIE :::"

    Public Property dtpDataEntrega() As CalendarCombo
        Get
            Return oDtpDataEntrega
        End Get
        Set(ByVal value As CalendarCombo)
            oDtpDataEntrega = value
        End Set
    End Property

    Public Property Item() As String
        Get
            Return sItem
        End Get
        Set(ByVal value As String)
            sItem = value
        End Set
    End Property

    Public Property Quantidade() As Double
        Get
            Return dQuantidade
        End Get
        Set(ByVal value As Double)
            dQuantidade = value
        End Set
    End Property

    Public Property DataEntrega() As String
        Get
            Return sDataEntrega
        End Get
        Set(ByVal value As String)
            sDataEntrega = value
        End Set
    End Property

    Public Property CodigoCotacao() As Long
        Get
            Return lCodigoCotacao
        End Get
        Set(ByVal value As Long)
            lCodigoCotacao = value
        End Set
    End Property

    Public Property CodigoCotacaoFornecedor() As Integer
        Get
            Return iCodigoCotacaoFornecedor
        End Get
        Set(ByVal value As Integer)
            iCodigoCotacaoFornecedor = value
        End Set
    End Property

    Public Property CodigoCotacaoItem() As Integer
        Get
            Return iCodigoCotacaoItem
        End Get
        Set(ByVal value As Integer)
            iCodigoCotacaoItem = value
        End Set
    End Property

#End Region

#Region "::: CONTROLES :::"

    Private Sub frmCmpCotacaoDesmembrarEntrega_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura Formulário
        Call ConfigurarFormulario()

    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click

        'Fecha o Controle
        Me.Dispose()

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

    Private Sub GeraEntregas() Handles txtNumeroEntrega.ValueChanged, _
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
                    oDataRow("prazo_entrega") = DateAdd(DateInterval.Day, (txtIntervaloEntrega.Value * (i - 1)), Now.Date)
                    oDataRow("quantidade") = FormatNumber(IIf(i = txtNumeroEntrega.Value, dQuantidadeResidual, txtQuantidade.Value / txtNumeroEntrega.Value), 2)
                    dQuantidadeResidual -= FormatNumber(txtQuantidade.Value / txtNumeroEntrega.Value, 2)
                    oDataTable.Rows.Add(oDataRow)
                Next

                With grdEntrega

                    .RootTable.Columns.Item("prazo_entrega").DataMember = "prazo_entrega"
                    .RootTable.Columns.Item("quantidade").DataMember = "quantidade"

                    .DataSource = oDataSet.DefaultViewManager
                    .DataMember = oDataSet.Tables(0).TableName

                End With

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

            'Váriaveis Locais
            Dim sAuxiliar(1) As String
            Dim sData() As String
            Dim sQuantidadeEntrega() As String

            'Seta Controle
            txtQuantidade.Value = dQuantidade

            If sDataEntrega <> "|" Then

                sAuxiliar = sDataEntrega.ToString.Split("|")
                sData = sAuxiliar(0).Split(";")
                sQuantidadeEntrega = sAuxiliar(1).Split(";")
                'Carrega Controle
                txtNumeroEntrega.Value = sData.Length
                'Carrega Desmembramento
                Call LoadDesmembramento(sData, sQuantidadeEntrega)

            Else

                'Verifica se a foi passado o Controle dtpDatEntrega
                If IsNothing(dtpDataEntrega) = False Then

                    'Verifica se a Data de Entrega está Desmembrada
                    If dtpDataEntrega.Tag <> "" Then
                        'Seta Vetor
                        sAuxiliar = dtpDataEntrega.Tag.ToString.Split("|")
                        sData = sAuxiliar(0).Split(";")
                        sQuantidadeEntrega = sAuxiliar(1).Split(";")
                        'Carrega Controle
                        txtNumeroEntrega.Value = sData.Length
                        'Carrega Desmembramento
                        Call LoadDesmembramento(sData, sQuantidadeEntrega)
                    Else
                        'Redimensiona Vetor
                        ReDim sData(0)
                        ReDim sQuantidadeEntrega(0)
                        'Seta Vetor
                        sData(0) = dtpDataEntrega.Value
                        sQuantidadeEntrega(0) = dQuantidade
                        'Carrega Controle
                        txtNumeroEntrega.Value = sData.Length
                        'Carrega Desmembramento
                        Call LoadDesmembramento(sData, sQuantidadeEntrega)
                    End If

                End If

            End If

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

            'Verificar se é para Alterar a Tabela
            If lCodigoCotacao > 0 Then

                'Váriaveis
                Dim oClsCmpCotacao As New clsUsrCmpCotacao

                'Exclui Registro da tb_cmp_cotacao_fornecedor_item_entrega
                Call oClsCmpCotacao.DeleteCotacaoFornecedorOrcamentoItemEntrega(lCodigoCotacao, _
                                                                                iCodigoCotacaoItem, _
                                                                                iCodigoCotacaoFornecedor)

                'Insere Previsões de Entrega
                For Each oRow As GridEXRow In grdEntrega.GetDataRows
                    'Insere Previsão de Entrega
                    Call oClsCmpCotacao.InsertCotacaoFornecedorOrcamentoItemEntrega(lCodigoCotacao, _
                                                                                    iCodigoCotacaoItem, _
                                                                                    iCodigoCotacaoFornecedor, _
                                                                                    oRow.Cells("prazo_entrega").Value, _
                                                                                    oRow.Cells("quantidade").Value)

                Next

            Else

                'Váriaveis
                Dim sAuxiliarData As String = ""
                Dim sAuxiliarQuantidade As String = ""

                For Each oRow As GridEXRow In grdEntrega.GetDataRows
                    sAuxiliarData &= IIf(sAuxiliarData = "", "", ";") & oRow.Cells("prazo_entrega").Value
                    sAuxiliarQuantidade &= IIf(sAuxiliarQuantidade = "", "", ";") & CDbl(oRow.Cells("quantidade").Value)
                Next

                dtpDataEntrega.Tag = sAuxiliarData & "|" & sAuxiliarQuantidade

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub LoadDesmembramento(ByVal sDataEntrega() As String, _
                                   ByVal sQuantidadeEntrega() As String)

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
            For i = 0 To UBound(sDataEntrega)
                Dim oDataRow As DataRow = oDataTable.NewRow
                oDataRow("prazo_entrega") = sDataEntrega(i)
                oDataRow("quantidade") = CDbl(sQuantidadeEntrega(i).Replace(".", ","))
                oDataTable.Rows.Add(oDataRow)
            Next

            'Seta Controle
            txtIntervaloEntrega.Value = UBound(sDataEntrega) + 1
            If UBound(sDataEntrega) > 0 Then
                txtIntervaloEntrega.Value = DateDiff(DateInterval.Day, CDate(sDataEntrega(0)), CDate(sDataEntrega(1)))
            End If

            'Preenche Grid
            With grdEntrega

                .RootTable.Columns.Item("prazo_entrega").DataMember = "prazo_entrega"
                .RootTable.Columns.Item("quantidade").DataMember = "quantidade"

                .DataSource = oDataSet.DefaultViewManager
                .DataMember = oDataSet.Tables(0).TableName

            End With

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
                frmMain.errInfo.SetError(lblQuantidade, "A Soma da Quantidade das Entregas é diferente da Quantidade Total.")
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