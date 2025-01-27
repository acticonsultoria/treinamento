Imports Janus.Windows.GridEX
Imports Janus.Windows.EditControls
Imports System.Math

Public Class frmFatEmissaoNFeImportacaoBoleta

#Region "::: VARIAVEIS :::"

    'Váriaveis
    Private oClsIntImportacaoNFe As New clsUsrIntImportacaoNFe
    Public lCodigoEmissaoCapa As Long
    Public lCodigoBoleta As Long
    Public sResultado As String
    Public sNumeroTicket As String
    Public iCodigoCliente As Integer
    Public sUF As String
    Public iCodigoPersonalidade As Integer


#End Region

#Region "::: PROPERTIE :::"
    Public Property UF() As String
        Get
            Return iCodigoPersonalidade
        End Get
        Set(ByVal value As String)
            sUF = value
        End Set
    End Property
    Public Property CodigoPersonalidade() As Integer
        Get
            Return iCodigoPersonalidade
        End Get
        Set(ByVal value As Integer)
            iCodigoPersonalidade = value
        End Set
    End Property
    Public Property NumeroTicket() As String
        Get
            Return sNumeroTicket
        End Get
        Set(ByVal value As String)
            sNumeroTicket = value
        End Set
    End Property
    Public Property CodigoBoleta() As Long
        Get
            Return lCodigoBoleta
        End Get
        Set(ByVal value As Long)
            lCodigoBoleta = value
        End Set
    End Property
    Public Property CodigoEmissaoCapa() As Long
        Get
            Return lCodigoEmissaoCapa
        End Get
        Set(ByVal value As Long)
            lCodigoEmissaoCapa = value
        End Set
    End Property

    Public Property Resultado() As String
        Get
            Return sResultado
        End Get
        Set(ByVal value As String)
            sResultado = value
        End Set
    End Property

#End Region

#Region "::: CONTROLES :::"

    Private Sub grdBoleta_CellUpdated(sender As Object, e As ColumnActionEventArgs) Handles grdBoleta.CellUpdated
        Try
            grdBoleta.CurrentRow.Cells.Item("descricao").Value = LoadCodigo("sp_select_cadastro_basico_descricao_item " & CInt(grdBoleta.CurrentRow.Cells("codigo_produto_servico").Value) & ", " & goUsuario.iEmpresa)
            grdBoleta.CurrentRow.Cells.Item("codigo_ncm").Value = LoadCodigo("sp_select_cadastro_basico_item_codigo_ncm " & CInt(grdBoleta.CurrentRow.Cells("codigo_produto_servico").Value) & ", " & goUsuario.iEmpresa)
            grdBoleta.CurrentRow.Cells.Item("ncm").Value = LoadCodigo("sp_select_cadastro_basico_codigo_ncm_boleta " & CInt(grdBoleta.CurrentRow.Cells("codigo_ncm").Value) & ", " & goUsuario.iEmpresa)
        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub


    Private Sub grdNF_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdBoleta.RowDoubleClick
        Try

            'Verifica se foi pressionado algum Registro
            If IsNothing(grdBoleta.CurrentColumn) Then Exit Sub

            'Verifica qual coluna foi pressionada
            Select Case grdBoleta.CurrentColumn.Key

                Case "codigo_produto_servico" : Call ProcurarItem()
                Case "regra_faturamento" : Call CadastrarRegraFaturamento()

            End Select


        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub
    Private Sub ProcurarItem()
        Try
            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindItem"
            oForm.Titulo = Me.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar Produto"

            'Seta Parametros
            iCodigoTipoItemFind = TipoItem.produto
            oGridEX = grdBoleta

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)



        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub frmFatEmissaoNFeProdutoXML_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

        'Configura Formulário
        Call ConfigurarFormulario()

    End Sub



    Private Sub btnConfigurarGridXML_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGridXML.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdBoleta
            oForm.NomeFormulario = Formulario.FaturamentoEntradaNF
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdBoleta, Formulario.FaturamentoEntradaNF)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnAgruparGridXML_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGridXML.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdBoleta.GroupByBoxVisible = True Then
                'Oculta Grupo
                grdBoleta.GroupByBoxVisible = False
            Else
                'Exibe Grupo
                grdBoleta.GroupByBoxVisible = True
                grdBoleta.HideColumnsWhenGrouped = InheritableBoolean.True
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnExcelGridXML_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGridXML.Click

        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdBoleta)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnConfirmar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirmar.Click

        Try

            'Valida Dados do Formulário
            If Validacao() = True Then

                'Salva Dados do Item
                Call SalvarXML()

                'Seta Váriavel 
                sResultado = "S"

                'Fecha o Formulário
                Me.Dispose()

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click

        Try

            'Verifica se o usuário deseja cancelar a importação da Nota Fiscal Eletrônica
            If MsgBox("Deseja Cancelar a Importação da Nota Fiscal Eletrônica?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes Then

                'Seta Váriavel 
                sResultado = "N"

                'Fecha o Formulário
                Me.Dispose()

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdNF_DropDown(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdBoleta.DropDown

    End Sub

    Private Sub grdXML_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdBoleta.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdBoleta.Name, _
                                     Formulario.FaturamentoEntradaNF, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdXML_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdBoleta.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdBoleta, _
                                     Formulario.FaturamentoEntradaNF)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdXML_GroupsChanging(ByVal sender As Object, ByVal e As GroupsChangingEventArgs) Handles grdBoleta.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdBoleta.Name, _
                                          Formulario.FaturamentoEntradaNF, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub



#End Region

#Region "::: FUNCTION / SUB :::"

    Private Function Validacao() As Boolean

        Try

            'Seta Retorno da Função
            Validacao = False
            Dim iCodigoRegra As Integer



            'Seta Váriavel
            If ValidaCampo(cboCliente, lblCliente) = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado algum Pedido de Venda
            For Each oRow As GridEXRow In grdBoleta.GetRows
                iCodigoRegra = IIf(LoadCodigo("sp_select_faturamento_regra_faturamento " & _
                                          oRow.Cells.Item("codigo_produto_servico").Value & ", " & _
                                          goUsuario.iEmpresa & ", " & _
                                          iCodigoPersonalidade & "," & _
                                          0 & ", " & _
                                          cboCliente.SelectedValue & ", '" & _
                                          txtUFDestino.Text & "', " & _
                                          oRow.Cells.Item("codigo_ncm").Value) = 0,
                                          -1,
                                          LoadCodigo("sp_select_faturamento_regra_faturamento " & _
                                          oRow.Cells.Item("codigo_produto_servico").Value & ", " & _
                                          goUsuario.iEmpresa & ", " & _
                                          iCodigoPersonalidade & "," & _
                                          0 & ", " & _
                                          cboCliente.SelectedValue & ", '" & _
                                          txtUFDestino.Text & "', " & _
                                          oRow.Cells.Item("codigo_ncm").Value))
                If iCodigoRegra = -1 Then
                    MsgBox("O Item " & oRow.Cells.Item("codigo_produto_servico").Text & " não possui regra de faturamento!")
                    Exit Function
                End If

            Next


            'Retorno da Função
            Validacao = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function
    Private Sub ConfigurarFormulario()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Ícone
            Me.Icon = frmMain.Icon

            'Adiciona KeyUP
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))

            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Seta Tamanho / Posição do Formulário
            Me.Size = frmMain.tlpMain.Size : Me.Location = New Point(0, 23)

            'Configura Grid
            Call ConfiguraGrid(grdBoleta, Formulario.FaturamentoEntradaNF)
            Call LoadCombo(cboCliente, "sp_select_combo_cadastro_basico_parceiro_negocio " & goUsuario.iEmpresa)
            If iCodigoCliente <> -1 Then
                cboCliente.SelectedValue = iCodigoCliente
                cboCliente.Enabled = False
            End If
            txtNumeroTicket.Text = sNumeroTicket

            oClsIntImportacaoNFe.LoadGridBoleta(grdBoleta, lCodigoBoleta)

            LoadComboGrid(grdBoleta, "codigo_produto_servico", "sp_select_combo_cadastro_basico_item_importacao " & goUsuario.iEmpresa)
            'Call LoadCombo(cboCFOP, "sp_select_combo_cadastro_basico_cfop_uf " & goUsuario.iEmpresa & ", 0, 'EX', '" & goEmitente.sUF & "'")
            'Carrega Combo - Grid
            Call LoadComboGrid(grdBoleta, "codigo_produto_servico", "sp_select_combo_cadastro_basico_item " & goUsuario.iEmpresa & ",null,null,1")



            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub SalvarXML()

        Try
            ExecuteQuery("UPDATE tb_fat_boleta set codigo_cliente = " & cboCliente.SelectedValue & "where codigo = " & lCodigoBoleta & _
                                "and codigo_empresa = " & goUsuario.iEmpresa)

            For Each oRow In grdBoleta.GetRows
                oClsIntImportacaoNFe.UpdateItemBoleta(lCodigoBoleta, _
                                                      oRow.Cells.Item("codigo").Value, _
                                                      oRow.Cells.Item("codigo_produto_servico").Value)
            Next

            oClsIntImportacaoNFe.ImportarBoleta(lCodigoEmissaoCapa, cboCliente.SelectedValue, lCodigoBoleta, grdBoleta)


        Catch ex As Exception
            Throw ex
        End Try

    End Sub
    Private Sub CadastrarRegraFaturamento()

        Try

            'Verifica se existe NCM cadastrado para o Produto
            If IsDBNull(grdBoleta.CurrentRow.Cells("codigo_ncm").Value) Then
                frmMain.Informacao(Mensagem.ValorInformadoNaoValido, "NCM")
                Exit Sub
            End If

            If IsDBNull(grdBoleta.CurrentRow.Cells("codigo_origem_item").Value) Then
                frmMain.Informacao(Mensagem.ValorInformadoNaoValido, "Origem do Item")
                Exit Sub
            End If

            'Carrega Váriaveis
            Dim oFormularioCadastroBasico(5) As FormularioCadastroBasico

            oFormularioCadastroBasico(0).oValor = 20 : oFormularioCadastroBasico(0).sControle = "cboTipoRegra"
            oFormularioCadastroBasico(1).oValor = grdBoleta.CurrentRow.Cells("codigo_ncm").Value : oFormularioCadastroBasico(1).sControle = "cboNCM"
            oFormularioCadastroBasico(2).oValor = iCodigoPersonalidade : oFormularioCadastroBasico(2).sControle = "cboPersonalidade"
            oFormularioCadastroBasico(3).oValor = grdBoleta.CurrentRow.Cells("codigo_origem_item").Value : oFormularioCadastroBasico(3).sControle = "cboOrigemItem"
            oFormularioCadastroBasico(4).oValor = txtUFDestino.Text : oFormularioCadastroBasico(4).sControle = "cboUFDestino"
            oFormularioCadastroBasico(5).oValor = grdBoleta.CurrentRow.Cells("codigo_destinacao").Value : oFormularioCadastroBasico(5).sControle = "cboDestinacao"

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrImpRegra"
            oForm.Size = frmMain.tlpMain.Size : oForm.Location = frmMain.tlpMain.Location : oForm.Tamanho = True
            oForm.CadastroBasico = oFormularioCadastroBasico
            oForm.Titulo = Me.Text
            'Abre o Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Recarrega a Grid
            ' oClsIntImportacaoNFe.LoadGridBoleta(grdBoleta, lCodigoBoleta)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub


#End Region


    Private Sub cboCliente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCliente.SelectedIndexChanged
        Try
            If cboCliente.SelectedIndex = -1 Then Exit Sub

            oClsIntImportacaoNFe.LoadDadosParceiroNegocio(cboCliente.SelectedValue, sUF, iCodigoPersonalidade)
            txtUFDestino.Text = sUF
        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnCadastrarCliente_Click(sender As Object, e As EventArgs) Handles btnCadastrarCliente.Click
        Try

            'Carrega o form de parceiro de negócio
            LoadUsrControlForm(Me, "usrCadParceiroNegocio")

            'Carrega Combo            
            LoadCombo(cboCliente, "sp_select_combo_cadastro_basico_cliente " & goUsuario.iEmpresa)

            'Seta Focu
            cboCliente.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnProcurarCliente_Click(sender As Object, e As EventArgs) Handles btnProcurarCliente.Click
        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindParceiroNegocio"
            oForm.Titulo = "Parceiro de Negócio"
            oForm.Tamanho = True
            oForm.Text = "Procurar Parceiro de Negócio"

            'Seta Parametros
            iCodigoTipoParceiroNegocioFind = TipoParceiroNegocio.cliente
            oComboBoxFind = cboCliente

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            cboCliente.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try
    End Sub
End Class

