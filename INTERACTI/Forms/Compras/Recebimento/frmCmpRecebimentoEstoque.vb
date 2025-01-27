Imports Janus.Windows.GridEX
Imports Janus.Windows.EditControls

Public Class frmCmpRecebimentoEstoque

#Region "::: VARIAVEIS :::"

    Private sProduto As String
    Private dQuantidade As Double
    Private sEstoque As String
    Private lCodigoItem As Long
    Private bControlaLote As Boolean
    Private dQuantidadeEstoque As Double

#End Region

#Region "::: PROPERTIE :::"

    Public Property Estoque() As String
        Get
            Return sEstoque
        End Get
        Set(ByVal value As String)
            sEstoque = value
        End Set
    End Property

    Public ReadOnly Property QuantidadeEstoque() As Double
        Get
            Return dQuantidade
        End Get
    End Property

    Public WriteOnly Property Produto() As String
        Set(ByVal value As String)
            sProduto = value
        End Set
    End Property

    Public WriteOnly Property Quantidade() As Double
        Set(ByVal value As Double)
            dQuantidade = value
        End Set
    End Property

    Public WriteOnly Property CodigoItem() As Long
        Set(ByVal value As Long)
            lCodigoItem = value
        End Set
    End Property

    Public WriteOnly Property ControlaLote() As Boolean
        Set(ByVal value As Boolean)
            bControlaLote = value
        End Set
    End Property

#End Region

#Region "::: CONTROLES :::"

#Region "::: GERAL :::"

    Private Sub frmCmpRecebimentoEstoque_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.F5

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    Select Case sender.Name
                        Case "cboDeposito" : Call LoadCombo(cboDeposito, "sp_select_combo_cadastro_basico_deposito " & goUsuario.iEmpresa & ", 1, NULL, 0", False)
                    End Select

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub frmCmpRecebimentoEstoque_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarFormulario()

    End Sub

#End Region

#Region "::: ESTOQUE :::"

    Private Sub btnConfigurarGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGrid.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdEstoque
            oForm.NomeFormulario = Formulario.ComprasRecebimento
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdEstoque, Formulario.ComprasRecebimento)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Deleta Registros
            Call Delete()
            'Limpa Formulário
            Call Novo()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnInserir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInserir.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Formulário
            If Validacao() = True Then

                'Váriavel
                Dim iCodigo As Integer = 1
                Dim iCodigoAntigo As Integer = 0

                'Preenche Váriavel - Código
                If grdEstoque.GetDataRows.Count > 0 Then
                    iCodigo = grdEstoque.GetTotalRow.Cells("codigo").Value + 1
                End If

                If IsNumeric(btnInserir.Tag) Then
                    iCodigoAntigo = grdEstoque.CurrentRow.Cells("codigo").Value
                End If

                'Salva Dados
                Call Insert(grdEstoque, _
                            cboDeposito.Text, _
                            cboDeposito.SelectedValue, _
                            txtQuantidade.Value, _
                            txtLote.Text.Trim, _
                            iCodigo, _
                            iCodigoAntigo)

                'Limpa Formulário
                Call Novo()

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnVoltar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVoltar.Click


        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Seta Váriavel
            sEstoque = ""
            dQuantidadeEstoque = 0

            For Each oRow As GridEXRow In grdEstoque.GetDataRows
                sEstoque &= IIf(sEstoque = "", "", "|") & oRow.Cells("codigo_deposito").Value & ";"
                sEstoque &= oRow.Cells("quantidade").Value.ToString.Replace(",", ".") & ";"
                sEstoque &= IIf(IsDBNull(oRow.Cells("lote").Value), "", oRow.Cells("lote").Value)
            Next

            If grdEstoque.GetDataRows.Count > 0 Then
                dQuantidadeEstoque = grdEstoque.GetTotalRow.Cells("quantidade").Value
            End If

            'Fecha o Formulário
            Me.Dispose()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdEstoque_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdEstoque.RowDoubleClick

        Try

            'Verifiva se a Linha é Válida
            If IsNothing(grdEstoque.CurrentColumn) Then Exit Sub

            'Verifica o Tipo de Operação
            Select Case grdEstoque.CurrentColumn.Key

                Case "editar" : Call Editar()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdEstoque_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdEstoque.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdEstoque.Name, _
                                     Formulario.ComprasRecebimento, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdEstoque_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdEstoque.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdEstoque, _
                                     Formulario.ComprasRecebimento)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#End Region

#Region "::: FUNCTION / SUB :::"

#Region "::: GERAL :::"

    Private Sub ConfigurarFormulario()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Ícone
            Me.Icon = frmMain.Icon

            'Adiciona KeyUP
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf frmCmpRecebimentoEstoque_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Carrega Combo
            Call LoadCombo(cboDeposito, "sp_select_combo_cadastro_basico_deposito " & goUsuario.iEmpresa & ", 1, NULL, 0", False)

            'Seta Controles
            txtProduto.Text = sProduto
            txtQuantidadeProduto.Value = dQuantidade
            txtLote.Enabled = bControlaLote

            'Configura Grid
            Call ConfiguraGrid(grdEstoque, Formulario.ComprasRecebimento)

            'Carrega Grid
            Call LoadGrid()

            'Seta Focu
            cboDeposito.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

#End Region

#Region "::: ESTOQUE :::"

    Private Sub Delete()

        Try

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdEstoque) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro” & iif(gSelecaoRow.Count = 1, “?", “s?”), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Váriavel - Linha
                    Dim oRow As GridEXRow

                    For Each oRow In gSelecaoRow
                        oRow.Delete()
                    Next

                    'Limpa Formulário
                    Call Novo()

                    'Informa o Usuário sobre o Sucesso da Operação
                    frmMain.Informacao(Mensagem.RegistroExcluido)

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                End If

            Else
                'Informa o Usuário da Necessidade de Selecionar um ou mai Registro
                frmMain.Informacao(Mensagem.ValidacaoSelecionar)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Insert(ByVal oGrid As GridEX, _
                       ByVal sDeposito As String, _
                       ByVal iCodigoDeposito As Integer, _
                       ByVal dQuantidade As Double, _
                       ByVal sLote As String, _
                       ByVal iCodigo As Integer, _
                       ByVal iCodigoAntigo As Integer)

        Try

            'Variaveis Locais
            Dim oDataSet As New DataSet
            Dim oDataTable As New DataTable
            Dim oDataRow As DataRow
            Dim oDCDeposito As New DataColumn("deposito")
            Dim oDCCodigoDeposito As New DataColumn("codigo_deposito")
            Dim oDCQuantidade As New DataColumn("quantidade")
            Dim oDCLote As New DataColumn("lote")
            Dim oDCCodigo As New DataColumn("codigo")

            'Verifica se o DataSource é Vazio
            If Not oGrid.DataSource Is Nothing Then
                oDataSet = oGrid.DataSource.DataSet
                oDataTable = oDataSet.Tables(0)
                oGrid.DataSource = Nothing
            Else
                'Adiciona Tabela ao DataSet
                oDataSet.Tables.Add(oDataTable)
                'Adiciona Colunas ao DataTable
                oDataTable.Columns.Add(oDCDeposito)
                oDataTable.Columns.Add(oDCCodigoDeposito)
                oDataTable.Columns.Add(oDCQuantidade)
                oDataTable.Columns.Add(oDCLote)
                oDataTable.Columns.Add(oDCCodigo)
                'Seta DataType
                oDCQuantidade.DataType = 0.0.GetType
            End If

            'Verifica o Tipo de Operação
            If IsNumeric(btnInserir.Tag) = False Then
                'Adiciona Linhas ao DataTable
                oDataRow = oDataTable.NewRow
                oDataRow("deposito") = sDeposito
                oDataRow("codigo_deposito") = iCodigoDeposito
                oDataRow("quantidade") = dQuantidade
                oDataRow("lote") = sLote
                oDataRow("codigo") = iCodigo
                oDataTable.Rows.Add(oDataRow)
            Else
                oDataRow = oDataTable.Select("(codigo = " & iCodigoAntigo & ")")(0)
                oDataRow("deposito") = sDeposito
                oDataRow("codigo_deposito") = iCodigoDeposito
                oDataRow("quantidade") = dQuantidade
                oDataRow("lote") = sLote
                oDataRow("codigo") = iCodigo
            End If

            'Configura DataMember
            Call ConfigurarDataMemberGrid(oGrid)

            'Carrega Grid
            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Editar()

        Try

            'Verifica se o usuário tem direito de alterar algum registro
            If VerificaDireito(Formulario.ComprasRecebimento, gcUpdate) = True Then

                'Limpa Erro
                frmMain.errInfo.Clear()

                'Limpa Controles
                Call Novo()

                'Carrega Controles
                cboDeposito.SelectedValue = grdEstoque.CurrentRow.Cells("codigo_deposito").Value
                txtQuantidade.Value = grdEstoque.CurrentRow.Cells("quantidade").Value
                txtLote.Text = IIf(IsDBNull(grdEstoque.CurrentRow.Cells("lote").Value), "", grdEstoque.CurrentRow.Cells("lote").Value)
                btnInserir.Tag = grdEstoque.CurrentRow.RowIndex

                'Seta Focu
                cboDeposito.Focus()

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub LoadGrid()

        Try

            'Váriaveis Locais
            Dim sLinha() As String
            Dim sDados() As String
            Dim i, j As Integer
            Dim iCodigo As Integer

            If sEstoque = "" Then Exit Sub

            sLinha = sEstoque.Split("|")

            For i = 0 To UBound(sLinha)

                sDados = sLinha(i).Split(";")

                For j = 0 To UBound(sLinha)

                    'Preenche Váriavel - Código
                    If grdEstoque.GetDataRows.Count > 0 Then
                        iCodigo = grdEstoque.GetTotalRow.Cells("codigo").Value + 1
                    Else
                        iCodigo = 1
                    End If

                    'Insere Registro na Grid
                    Call Insert(grdEstoque, _
                                LoadDescricao("sp_select_cadastro_basico_descricao_deposito " & sDados(0) & ", " & goUsuario.iEmpresa), _
                                sDados(0), _
                                sDados(1), _
                                sDados(2), _
                                iCodigo, _
                                -1)

                Next

            Next

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Novo()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Limpa Controles - Dependente
            cboDeposito.SelectedIndex = -1
            txtQuantidade.Value = 0
            txtLote.Text = ""
            btnInserir.Tag = ""

            'Seta Focu
            cboDeposito.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function Validacao() As Boolean

        Try

            'Seta Retorno da Função
            Validacao = False

            'Verifica se foi Selecionado o Campo - Depósito
            If ValidaCampo(cboDeposito, lblDeposito) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Quantidade
            If ValidaCampo(txtQuantidade, lblQuantidade, True) = False Then
                Exit Function
            End If

            'Verifica se a Quantidade é Válida
            Dim dQuantidade As Double
            If grdEstoque.GetDataRows.Count > 0 Then dQuantidade = grdEstoque.GetTotalRow.Cells("quantidade").Value
            If IsNumeric(btnInserir.Tag) Then
                dQuantidade -= grdEstoque.CurrentRow.Cells("quantidade").Value
            End If
            If txtQuantidade.Value + dQuantidade > txtQuantidadeProduto.Value Then
                frmMain.errInfo.SetError(lblQuantidade, "A Soma das Quantidades não pode ser maior que a Quantidade do Produto.")
                txtQuantidade.Focus()
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Lote
            If txtLote.Enabled = True Then
                If ValidaCampo(txtLote, lblLote, TipoCampo.texto) = False Then
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

#End Region

End Class

