Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls
Imports Janus.Windows.EditControls

Public Class frmFatEmissaoItemImportar

#Region "::: VARIAVEIS :::"

    Private oClsFatNFeItem As New clsFrmFatItem
    Private iTipoDocumento As TipoDocumentoFiscal
    Private oClsFrmFatEmissaoItemImportar As New clsFrmFatEmissaoItemImportar
    Private sUFDestinatario As String
    Private lCodigoEmissaoCapa As Long
    Private lCodigoItem As Long
    Private iRow As Integer
    Private oGrid As GridEX
    Private sCSTICMS As String
    Private dICMS As Double

    Private bFlag As Boolean
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

    Public Property TipoDocumento() As Integer
        Get
            Return iTipoDocumento
        End Get
        Set(ByVal value As Integer)
            iTipoDocumento = value
        End Set
    End Property

    Public Property UFDestinatario() As String
        Get
            Return sUFDestinatario
        End Get
        Set(ByVal value As String)
            sUFDestinatario = value
        End Set
    End Property

    Public Property Grid() As GridEX
        Get
            Return oGrid
        End Get
        Set(ByVal value As GridEX)
            oGrid = value
        End Set
    End Property

#End Region

#Region "::: CONTROLES :::"

    Private Sub frmFatItem_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarForm()

    End Sub

    Private Sub btnInserir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImportar2.Click, _
                                                                                                     btnImportar.Click

        'Limpa Erro
        frmMain.errInfo.Clear()
        bFlag = False
        'Valida Dados do Formulário
        If Validacao() = True Then

            Dim iCont As Integer
            Dim oRow() As Janus.Windows.GridEX.GridEXRow = grdListagem.GetCheckedRows

            For iCont = 0 To oRow.Count - 1

                'Insere Item
                If InsertItem(oRow(iCont)) = False Then Exit Sub

                'Insere Imposto - ICMS
                If cboSituacaoTributariaICMS.SelectedIndex <> -1 Then Call InsertImpostoICMS()
                'Insere Imposto - IPI
                If cboSituacaoTributariaIPI.SelectedIndex <> -1 Then Call InsertImpostoIPI(oRow(iCont))
                'Insere Imposto - PIS
                If cboSituacaoTributariaPIS.SelectedIndex <> -1 Then Call InsertImpostoPIS(oRow(iCont))
                'Insere Imposto - COFINS
                If cboSituacaoTributariaCOFINS.SelectedIndex <> -1 Then Call InsertImpostoCOFINS(oRow(iCont))

            Next

            'Fechando o formulário
            Me.Dispose()


        End If

    End Sub

    Private Sub btnVoltar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVoltarTributos.Click, _
                                                                                                    btnVoltarDados.Click

        'Fecha Formulário
        Me.Dispose()

    End Sub

    Private Sub cboCFOP_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCFOP.SelectedIndexChanged

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Verificando se foi selecionado algum registro
            If cboCFOP.SelectedIndex > -1 Then

                'Carrega Combo Situação Tributária
                Call LoadComboFaturamento(cboSituacaoTributariaICMS, _
                               "sp_select_combo_static_situacao_tributaria_icms_cfop " & cboCFOP.SelectedValue)
                Call LoadComboFaturamento(cboSituacaoTributariaPIS, _
                               "sp_select_combo_static_situacao_tributaria_pis_cfop " & cboCFOP.SelectedValue)
                Call LoadComboFaturamento(cboSituacaoTributariaCOFINS, _
                               "sp_select_combo_static_situacao_tributaria_cofins_cfop " & cboCFOP.SelectedValue)

                cboSituacaoTributariaICMS.Text = sCSTICMS
                txtAliquotaICMS.Value = dICMS

                'Pré-determinado se houver somente um registro
                cboSituacaoTributariaPIS.SelectedIndex = IIf(cboSituacaoTributariaPIS.Items.Count = 1, 0, -1)
                cboSituacaoTributariaCOFINS.SelectedIndex = IIf(cboSituacaoTributariaCOFINS.Items.Count = 1, 0, -1)

            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            TratamentoErro(ex.Message.ToString, Me.Parent.ToString)
        End Try

    End Sub

    Private Sub cboSituacaoTributariaICMS_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSituacaoTributariaICMS.SelectedIndexChanged

        'Verifica se foi Selecionado algum Registro
        If cboSituacaoTributariaICMS.SelectedIndex <> -1 Then

            'Carrega Descrição
            Call LoadDescricao(txtDescricaoSituacaoTributariaICMS, _
                               "sp_select_static_descricao_situacao_tributaria_icms " & cboSituacaoTributariaICMS.SelectedValue)

            'ICMS
            For Each oControl In grpICMS.Controls
                'Caso não seja Label
                If Not TypeOf oControl Is Label Then
                    If InStr(oControl.Tag, "|" & Mid(cboSituacaoTributariaICMS.Text, 2) & "|", CompareMethod.Text) > 0 Then
                        oControl.Enabled = True
                    Else
                        oControl.Enabled = False
                    End If
                End If
            Next

            'ICMS ST
            For Each oControl In grpICMSST.Controls
                'Caso não seja Label
                If Not TypeOf oControl Is Label Then
                    If InStr(oControl.Tag, "|" & Mid(cboSituacaoTributariaICMS.Text, 2) & "|", CompareMethod.Text) > 0 Then
                        oControl.Enabled = True
                    Else
                        oControl.Enabled = False
                    End If
                End If
            Next

        Else

            'Limpa Controle
            txtDescricaoSituacaoTributariaICMS.Text = ""

            'Desabilita Controles grpICMS
            For Each oControl In grpICMS.Controls
                If Not TypeOf oControl Is Label Then
                    oControl.Enabled = False
                End If
            Next

            'Desabilita Controles grpICMSST
            For Each oControl In grpICMSST.Controls
                If Not TypeOf oControl Is Label Then
                    oControl.Enabled = False
                End If
            Next

        End If

    End Sub

    Private Sub cboSituacaoTributariaIPI_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSituacaoTributariaIPI.SelectedIndexChanged

        'Verifica se foi Selecionado algum Registro
        If cboSituacaoTributariaIPI.SelectedIndex <> -1 Then

            'Carrega Descrição
            Call LoadDescricao(txtDescricaoSituacaoTributariaIPI, _
                               "sp_select_static_descricao_situacao_tributaria_ipi " & cboSituacaoTributariaIPI.SelectedValue)


        Else

            'Limpa Controle
            txtDescricaoSituacaoTributariaIPI.Text = ""

        End If

    End Sub

    Private Sub cboSituacaoTributariaPIS_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSituacaoTributariaPIS.SelectedIndexChanged

        'Verifica se foi Selecionado algum Registro
        If cboSituacaoTributariaPIS.SelectedIndex <> -1 Then

            'Carrega Descrição
            Call LoadDescricao(txtDescricaoSituacaoTributariaPIS, _
                               "sp_select_static_descricao_situacao_tributaria_pis " & cboSituacaoTributariaPIS.SelectedValue)

            'PIS
            For Each oControl In grpPIS.Controls
                'Caso não seja Label
                If Not TypeOf oControl Is Label Then
                    If InStr(oControl.Tag, "|" & cboSituacaoTributariaPIS.Text & "|", CompareMethod.Text) > 0 Then
                        oControl.Enabled = True
                    Else
                        oControl.Enabled = False
                    End If
                End If
            Next

            'Verificando se existe a alíquota
            If txtAliquotaPIS.Enabled = True Then
                txtAliquotaPIS.Value = 1.65
            Else
                txtAliquotaPIS.Value = 0
            End If
        Else

            'Limpa Controle
            txtDescricaoSituacaoTributariaPIS.Text = ""

            'Desabilita Controles grpPIS
            For Each oControl In grpPIS.Controls
                If Not TypeOf oControl Is Label Then
                    oControl.Enabled = False
                End If
            Next

            'Desabilita Controles grpPISSST
            For Each oControl In grpPISST.Controls
                If Not TypeOf oControl Is Label Then
                    oControl.Enabled = False
                End If
            Next

        End If

    End Sub

    Private Sub cboSituacaoTributariaCOFINS_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSituacaoTributariaCOFINS.SelectedIndexChanged

        'Verifica se foi Selecionado algum Registro
        If cboSituacaoTributariaCOFINS.SelectedIndex <> -1 Then

            'Carrega Descrição
            Call LoadDescricao(txtDescricaoSituacaoTributariaCOFINS, _
                               "sp_select_static_descricao_situacao_tributaria_cofins " & cboSituacaoTributariaCOFINS.SelectedValue)

            'COFINS
            For Each oControl In grpCOFINS.Controls
                'Caso não seja Label
                If Not TypeOf oControl Is Label Then
                    If InStr(oControl.Tag, "|" & cboSituacaoTributariaCOFINS.Text & "|", CompareMethod.Text) > 0 Then
                        oControl.Enabled = True
                    Else
                        oControl.Enabled = False
                    End If
                End If
            Next

            'Verificando se existe a alíquota
            If txtAliquotaCOFINS.Enabled = True Then
                txtAliquotaCOFINS.Value = 7.6
            Else
                txtAliquotaCOFINS.Value = 0
            End If

        Else

            'Limpa Controle
            txtDescricaoSituacaoTributariaCOFINS.Text = ""

            'Desabilita Controles grpcofins
            For Each oControl In grpCOFINS.Controls
                If Not TypeOf oControl Is Label Then
                    oControl.Enabled = False
                End If
            Next

            'Desabilita Controles grpcofinsSST
            For Each oControl In grpCOFINSST.Controls
                If Not TypeOf oControl Is Label Then
                    oControl.Enabled = False
                End If
            Next

        End If

    End Sub

    Private Sub btnProcurar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurar.Click
        Try

            'Váriaveis Locais
            Dim oFolder As New OpenFileDialog

            'Abre PopUp para Usuário selecionar Imagem
            oFolder.InitialDirectory = "c:\\dados"
            oFolder.Filter = "(Arquivos Excel)|*.XLS;*.XLSX"
            oFolder.Title = "Selecione o Arquivo"

            If oFolder.ShowDialog() = DialogResult.OK Then
                txtCaminhoPlanilha.Text = oFolder.FileName
            End If

        Catch ex As Exception
            'Trata Erro
            TratamentoErro(ex.Message.ToString, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub btnCarregarPlanilha_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCarregarPlanilha.Click
        CarregarPlanilha()
    End Sub

#End Region

#Region "::: FUNCTION / SUB :::"

    Private Sub ConfigurarForm()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor



            'Carrega Combo - Item
            Call LoadComboFaturamento(cboCFOP, "sp_select_combo_cadastro_basico_cfop_uf " & goUsuario.iEmpresa & ", " & iTipoDocumento & ", '" & sUFDestinatario & "', '" & goEmitente.sUF & "'")
            'Carrega Combo - ICMS
            Call LoadComboFaturamento(cboSituacaoTributariaICMS, "sp_select_combo_static_situacao_tributaria_icms")
            'Carrega Combo - IPI
            Call LoadComboFaturamento(cboSituacaoTributariaIPI, "sp_select_combo_static_situacao_tributaria_ipi")
            'Carrega Combo - PIS
            Call LoadComboFaturamento(cboSituacaoTributariaPIS, "sp_select_combo_static_situacao_tributaria_pis ")
            'Carrega Combo - COFINS
            Call LoadComboFaturamento(cboSituacaoTributariaCOFINS, "sp_select_combo_static_situacao_tributaria_pis ")


            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            TratamentoErro(ex.Message.ToString, Me.Parent.ToString)
        End Try

    End Sub

    Private Function InsertItem(ByVal oRow As Janus.Windows.GridEX.GridEXRow) As Boolean

        Try
            Dim lCodigoItem As Long

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'RFetorno da função
            InsertItem = False

            'Recebendo o código do item
            lCodigoItem = oRow.Cells.Item("codigo_item").Value

            With oRow.Cells

                If lCodigoItem = -1 Then


                    'Flag para não perguntar várias vezes se deseja cadastrar o item
                    If bFlag = True Then
                        'Cadastrando produto
                        lCodigoItem = CadastrarProduto(oRow)
                    Else
                        If MsgBox("O Part number [" & .Item("part_number").Value & "] não está cadastrado. Deseja cadastrá-lo para continuar?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Inserindo Item") = MsgBoxResult.No Then
                            Exit Function
                            Me.Dispose()

                        Else
                            'Cadastrando produto
                            lCodigoItem = CadastrarProduto(oRow)
                            bFlag = True
                        End If
                    End If



                End If


                'Seta Valores do Item
                oClsFatNFeItem.CodigoEmissaoCapa = lCodigoEmissaoCapa
                oClsFatNFeItem.CodigoTipoItem = TipoItem.produto
                oClsFatNFeItem.CodigoItem = lCodigoItem
                oClsFatNFeItem.Codigo = .Item("part_number").Value
                ' oClsFatNFeItem.CodigoFornecedor = .Item("codigo_cliente").Value
                oClsFatNFeItem.Descricao = .Item("descricao").Value
                oClsFatNFeItem.CodigoCFOP = cboCFOP.SelectedValue
                oClsFatNFeItem.NCM = Replace(.Item("classificacao_fiscal").Value, ".", "")
                oClsFatNFeItem.CodigoNCM = oClsFrmFatEmissaoItemImportar.CarregarCodigoNCM(Replace(.Item("classificacao_fiscal").Value, ".", ""))
                oClsFatNFeItem.CFOP = cboCFOP.Text.Trim
                oClsFatNFeItem.Lote = IIf(IsDBNull(.Item("lote").Value), "", .Item("lote").Value)
                oClsFatNFeItem.PrazoRetorno = ""
                oClsFatNFeItem.Quantidade = .Item("quantidade").Value
                oClsFatNFeItem.CodigoUnidadeMedida = oClsFrmFatEmissaoItemImportar.CarregarCodigoUnidadeMedida(.Item("unidade_medida").Value)
                oClsFatNFeItem.UnidadeMedida = .Item("unidade_medida").Value
                oClsFatNFeItem.ValorUnitario = .Item("valor_unitario").Value
                oClsFatNFeItem.ValorTotal = .Item("valor_total").Value


                'Adiciona Item
                oClsFatNFeItem.InsertItem2()


                InsertItem = True
            End With
            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            TratamentoErro(ex.Message.ToString, Me.Parent.ToString)
        End Try

    End Function

    Private Function CadastrarProduto(ByVal oRow As Janus.Windows.GridEX.GridEXRow) As Long
        Try
            Dim oClsUsrCadItemImportar As New clsUsrCadItemImportar

            With oClsUsrCadItemImportar
                'Seta Parametros
                .Codigo = -1
                .Codigopn = oRow.Cells.Item("part_number").Value
                .TipoItem = TipoItem.produto
                .GrupoItem = 28 ' GRUPO DE ITEM - IMPORTADOS
                '.CodigoFornecedor = oRow.Cells.Item("part_number").Value
                '.DescricaoIdioma = ""
                .Ativo = True
                .Descricao = oRow.Cells.Item("descricao").Value
                .CodigoNCM = oClsFrmFatEmissaoItemImportar.CarregarCodigoNCM(Replace(oRow.Cells.Item("classificacao_fiscal").Value, ".", ""))
                .IPI = 0
                .IVA = 0
                .UnidadeMedida = oClsFrmFatEmissaoItemImportar.CarregarCodigoUnidadeMedida(oRow.Cells.Item("unidade_medida").Value)
                '.CodigoUnidadeMedidaVenda = oClsFrmFatEmissaoItemImportar.CarregarCodigoUnidadeMedida(oRow.Cells.Item("unidade_medida").Value)
                .Observacao = "IMPORTAÇÃO"
                .Foto = ""
                .Estoque = True
                .Compra = True
                .Venda = True
                .AtivoFixo = False
                .ControlaLote = False
                .FornecedorPadrao = -1
                'Inserindo
                .Insert()

                'Retornando o código cadastrado
                CadastrarProduto = .Codigo
            End With


        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub InsertImpostoICMS()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Valores do Item
            oClsFatNFeItem.CSTICMS = IIf(cboSituacaoTributariaICMS.SelectedIndex = -1, -1, cboSituacaoTributariaICMS.SelectedValue)
            oClsFatNFeItem.STICMS = cboSituacaoTributariaICMS.Text.Trim
            oClsFatNFeItem.ModalidadeBCICMS = 3
            oClsFatNFeItem.ReducaoBCICMS = txtPorcentagemReducaoBCICMS.Value
            oClsFatNFeItem.BCICMS = 0
            oClsFatNFeItem.AliquotaICMS = txtAliquotaICMS.Value
            oClsFatNFeItem.ValorICMS = 0
            oClsFatNFeItem.ModalidadeBCICMSST = -1
            oClsFatNFeItem.IVA = txtIVA.Value
            oClsFatNFeItem.ReducaoBCICMSST = txtPorcentagemReducaoBCICMSST.Value
            oClsFatNFeItem.BCICMSST = 0
            oClsFatNFeItem.AliquotaICMSST = txtAliquotaICMSST.Value
            oClsFatNFeItem.ValorICMSST = 0

            'Adiciona Item
            oClsFatNFeItem.InsertImpostoICMS()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            TratamentoErro(ex.Message.ToString, Me.Parent.ToString)
        End Try

    End Sub

    Private Sub InsertImpostoIPI(ByVal oRow As Janus.Windows.GridEX.GridEXRow)

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Valores do Item 
            oClsFatNFeItem.CSTIPI = cboSituacaoTributariaIPI.SelectedValue
            oClsFatNFeItem.STIPI = cboSituacaoTributariaIPI.Text.Trim
            oClsFatNFeItem.BCIPI = IIf(txtAliquotaIPI.Value > 0, oRow.Cells.Item("valor_total").Value, 0)
            oClsFatNFeItem.AliquotaIPI = txtAliquotaIPI.Value
            oClsFatNFeItem.ValorIPI = IIf(txtAliquotaIPI.Value > 0, oRow.Cells.Item("valor_total").Value, 0) * txtAliquotaIPI.Value / 100
            oClsFatNFeItem.TipoCalculoIPI = 1
            'Adiciona Item
            oClsFatNFeItem.InsertImpostoIPI()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            TratamentoErro(ex.Message.ToString, Me.Parent.ToString)
        End Try

    End Sub

    Private Sub InsertImpostoPIS(ByVal oRow As Janus.Windows.GridEX.GridEXRow)

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Valores do Item
            oClsFatNFeItem.CSTPIS = cboSituacaoTributariaPIS.SelectedValue
            oClsFatNFeItem.STPIS = cboSituacaoTributariaPIS.Text.Trim
            oClsFatNFeItem.BCPIS = IIf(txtAliquotaPIS.Value > 0, oRow.Cells.Item("valor_total").Value, 0)
            oClsFatNFeItem.AliquotaPIS = txtAliquotaPIS.Value
            oClsFatNFeItem.ValorPIS = oRow.Cells.Item("valor_total").Value * txtAliquotaPIS.Value / 100
            oClsFatNFeItem.BCPISST = 0
            oClsFatNFeItem.TipoCalculoPIS = 1
            oClsFatNFeItem.AliquotaPISST = txtAliquotaPISST.Value
            oClsFatNFeItem.ValorPISST = 0
            oClsFatNFeItem.TipoCalculoPIS = 1
            oClsFatNFeItem.TipoCalculoPISST = -1


            'Adiciona Item
            oClsFatNFeItem.InsertImpostoPIS()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            TratamentoErro(ex.Message.ToString, Me.Parent.ToString)
        End Try

    End Sub

    Private Sub InsertImpostoCOFINS(ByVal oRow As Janus.Windows.GridEX.GridEXRow)

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Valores do Item
            oClsFatNFeItem.CSTCOFINS = cboSituacaoTributariaCOFINS.SelectedValue
            oClsFatNFeItem.STCOFINS = cboSituacaoTributariaCOFINS.Text.Trim
            oClsFatNFeItem.BCCOFINS = IIf(txtAliquotaCOFINS.Value > 0, oRow.Cells.Item("valor_total").Value, 0)
            oClsFatNFeItem.AliquotaCOFINS = txtAliquotaCOFINS.Value
            oClsFatNFeItem.ValorCOFINS = oRow.Cells.Item("valor_total").Value * txtAliquotaCOFINS.Value / 100
            oClsFatNFeItem.BCCOFINSST = 0
            oClsFatNFeItem.AliquotaCOFINSST = txtAliquotaCOFINSST.Value
            oClsFatNFeItem.ValorCOFINSST = 0
            oClsFatNFeItem.TipoCalculoCOFINS = 1
            oClsFatNFeItem.TipoCalculoCOFINSST = -1

            'Adiciona Item
            oClsFatNFeItem.InsertImpostoCOFINS()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            TratamentoErro(ex.Message.ToString, Me.Parent.ToString)
        End Try

    End Sub

    Private Function Validacao() As Boolean

        Try

            'Seta Retorno da Função
            Validacao = False

            'Verifica se foi Selecionado o Campo - CFOP
            If ValidaCampo(cboCFOP, lblCFOP) = False Then
                Exit Function
            End If


            'Verifica se foi selecionado os itens
            If grdListagem.GetCheckedRows.Count = 0 Then
                frmMain.Informacao("Selecione ao menos um registro!", Color.Red)
                Exit Function
            End If

            'Verifica se foi Selecionado a Situação Tributária do ICMS
            If ValidaCampo(cboSituacaoTributariaICMS, lblSituacaoTributariaICMS) = False Then
                tabMain.SelectedTab = pagTributos : tabTributo.SelectedTab = pagICMS
                cboSituacaoTributariaICMS.Focus()
                Exit Function
            End If

            'Verifica se foi Selecionado a Situação Tributária do PIS
            If ValidaCampo(cboSituacaoTributariaPIS, lblSituacaoTributariaPIS) = False Then
                tabMain.SelectedTab = pagTributos : tabTributo.SelectedTab = pagPIS
                cboSituacaoTributariaPIS.Focus()
                Exit Function
            End If


            'Verifica se foi Selecionado a Situação Tributária do COFINS
            If ValidaCampo(cboSituacaoTributariaCOFINS, lblSituacaoTributariaCOFINS) = False Then
                tabMain.SelectedTab = pagTributos : tabTributo.SelectedTab = pagCOFINS
                cboSituacaoTributariaCOFINS.Focus()
                Exit Function
            End If

            With grdListagem

                For Each oRow As GridEXRow In grdListagem.GetCheckedRows

                    'Verificando a classificação fiscal
                    If Len(Replace(oRow.Cells.Item("classificacao_fiscal").Value, ".", "")) <> 8 Then

                        frmMain.Informacao("Classificação fiscal dos itens no formato inválido!", Color.Red)
                        Exit Function

                    End If

                Next

            End With


            'Seta Retorno da Função
            Validacao = True

        Catch ex As Exception
            'Trata Erro
            TratamentoErro(ex.Message.ToString, Me.Parent.ToString)
        End Try

    End Function

    Private Sub CarregarPlanilha()
        Try


            'Validando 
            If ValidarCarregarPlanilha() = True Then

                With oClsFrmFatEmissaoItemImportar

                    'Passagem dos parâmetros
                    .CaminhoPlanilha = txtCaminhoPlanilha.Text
                    .NomePlanilha = txtPlanilha.Text

                    'Carregando todos itens na grid
                    .Importar(grdListagem)

                    'Carregando as informações da Capa da importação
                    sCSTICMS = .CSTICMS
                    dICMS = .ICMS
                    cboSituacaoTributariaICMS.Text = Replace(.CSTICMS, ".", "")
                    txtAliquotaICMS.Value = .ICMS
                    txtAliquotaIPI.Value = .IPI
                    cboSituacaoTributariaPIS.Text = "08"
                    cboSituacaoTributariaCOFINS.Text = "08"


                End With
            End If


        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function ValidarCarregarPlanilha() As Boolean
        Try
            ValidarCarregarPlanilha = False

            'Validando se foi inserido o caminho
            If ValidaCampo(txtCaminhoPlanilha, lblCaminhoPlaninha, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Verificando se o arquivo existe
            If System.IO.File.Exists(txtCaminhoPlanilha.Text) = False Then
                frmMain.Informacao("Esse arquivo não existe!", Color.Red)
                Exit Function
            End If

            ValidarCarregarPlanilha = True
        Catch ex As Exception
            Throw ex
        End Try
    End Function
#End Region



  
  
  
End Class
