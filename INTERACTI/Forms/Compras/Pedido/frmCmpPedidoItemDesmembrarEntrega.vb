Imports Janus.Windows.GridEX
Imports Janus.Windows.CalendarCombo

Public Class frmCmpPedidoItemDesmembrarEntrega

#Region "::: VARIAVEIS :::"

    'Variável da Classe
    Private oDtpDataEntrega As CalendarCombo
    Private sItem As String
    Private dQuantidade As Double

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

#End Region

#Region "::: CONTROLES :::"

    Private Sub frmCmpPedidoItemDesmembrarEntrega_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Escape : Me.Dispose()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub frmCmpPedidoItemDesmembrarEntrega_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura Formulário
        Call ConfigurarFormulario()

    End Sub

    Private Sub frmCmpPedidoItemDesmembrarEntrega_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

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
                    oDataRow("quantidade") = FormatNumber(IIf(i = txtNumeroEntrega.Value, dQuantidadeResidual, txtQuantidade.Value / txtNumeroEntrega.Value), 2)
                    dQuantidadeResidual -= FormatNumber(txtQuantidade.Value / txtNumeroEntrega.Value, 2)
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

            'Adiciona KeyUP
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf frmCmpPedidoItemDesmembrarEntrega_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Seta Controle
            txtItem.Text = sItem
            txtQuantidade.Value = dQuantidade

            'Váriaveis Locais
            Dim sAuxiliar(1) As String
            Dim sDataEntrega() As String
            Dim sQuantidadeEntrega() As String

            'Verifica se a Data de Entrega está Desmembrada
            If dtpDataEntrega.Tag.ToString <> "" Then
                'Carrega Vetor
                sAuxiliar = dtpDataEntrega.Tag.ToString.Split("|")
                sDataEntrega = sAuxiliar(0).Split(";")
                sQuantidadeEntrega = sAuxiliar(1).Split(";")
            Else
                'Redimensiona / Carrega Vetor
                ReDim sDataEntrega(0) : sDataEntrega(0) = dtpDataEntrega.Value
                ReDim sQuantidadeEntrega(0) : sQuantidadeEntrega(0) = dQuantidade
            End If

            'Seta Controle
            txtNumeroEntrega.Value = sDataEntrega.Length

            'Carrega Desmembramento
            Call LoadEntrega(sDataEntrega, sQuantidadeEntrega)

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

            Dim i As Integer
            Dim sAuxiliarData As String = ""
            Dim sAuxiliarQuantidade As String = ""
            Dim oRow() As GridEXRow = grdEntrega.GetDataRows

            For i = 0 To UBound(oRow)
                sAuxiliarData &= IIf(sAuxiliarData = "", "", ";") & oRow(i).Cells("prazo_entrega").Value
                sAuxiliarQuantidade &= IIf(sAuxiliarQuantidade = "", "", ";") & CDbl(oRow(i).Cells("quantidade").Value)
            Next

            dtpDataEntrega.Tag = sAuxiliarData & "|" & sAuxiliarQuantidade

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub LoadEntrega(ByVal sDataEntrega() As String, _
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