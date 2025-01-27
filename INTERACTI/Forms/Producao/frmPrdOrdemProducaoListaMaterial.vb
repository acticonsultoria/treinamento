Imports System.Diagnostics.Eventing.Reader
Imports System.Globalization
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls

Public Class frmPrdOrdemProducaoListaMaterial

#Region "::: VARIAVEIS :::"

    'Variável da Classe
    Private oClsPrdOrdemProducao As New clsUsrPrdProducaoManual
    Private lCodigoOrdemProducao As Long
    Private lCodigoRequisicao As Long
    Private lCodigoRequisicaoItem As Long

#End Region

#Region "::: PROPERTIE :::"
    Public WriteOnly Property CodigoRequsicao As Long
        Set(value As Long)
            lCodigoRequisicao = value
        End Set
    End Property

    Public WriteOnly Property CodigoRequsicaoItem As Long
        Set(value As Long)
            lCodigoRequisicaoItem = value
        End Set
    End Property

    Public WriteOnly Property CodigoOrdemProducao() As Long
        Set(ByVal value As Long)
            lCodigoOrdemProducao = value
        End Set
    End Property

#End Region

#Region "::: CONTROLES :::"

#Region "::: GERAL :::"

    Private Sub frm_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura Formulário
        Call ConfigurarFormulario()

    End Sub

#End Region

#Region "::: LISTA MATERIAL :::"
    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click

        Try

            'Fecha o Controle
            Me.Dispose()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnSalvarRequisicao_Click(sender As Object, e As EventArgs) Handles btnSalvarRequisicao.Click

        Try
            'Limpa os erros
            frmMain.errInfo.Clear()

            'Valida os campos
            If ValidacaoRequisicao() = False Then Exit Sub

            Select Case cboTipoRequisicao.SelectedValue
                Case 1 : SalvarRequisicaoCompra() 'COMPRA
                Case 2 : SalvarRequisicaoEstoque() 'ESTOQUE
                Case 3 ' CORTE
                    If ValidacaoRequisicaoCorte() = False Then Exit Sub
                    SalvarRequisicaoCorte()
            End Select

            'finaliza o formulário
            Me.Dispose()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub cboTipoRequisicao_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipoRequisicao.SelectedIndexChanged
        Try

            If cboTipoRequisicao.SelectedIndex = -1 Then ExibirCorteMaterial(False) : Exit Sub

            cboUnidadeMedida.SelectedIndex = -1 : cboUnidadeMedida.Enabled = True

            Select Case cboTipoRequisicao.SelectedValue
                Case 1 : ExibirCorteMaterial(False)
                Case 2 : ExibirCorteMaterial(False)
                Case 3
                    cboUnidadeMedida.Enabled = False : cboUnidadeMedida.SelectedValue = 2 'KG
                    cboUnidadeMedidaCorte.Enabled = False : cboUnidadeMedidaCorte.SelectedValue = 2 'KG
                    ExibirCorteMaterial(True) : LoadTipoPerfilCorte()

            End Select

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try
    End Sub

    Private Sub btnFindGrupoItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFindGrupoItem.Click

        Try

            frmMain.errInfo.Clear()
            'If ValidaCampo(cboTipoRequisicao, lblTipoRequisicao) = False Then Exit Sub

            LimparCampos()

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindGrupoItem2"
            oForm.Titulo = Me.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar Grupo de Item"
            oForm.Tag = "MP"
            lGrupoItemCodigoOrdemProducao = lCodigoOrdemProducao


            cboGrupoItemRequisicaoListaMaterial.Tag = ""

            'Seta Parametros
            oComboBoxFindGrupoItemProduto = cboGrupoItemRequisicaoListaMaterial
            oComboBoxFind = cboCodigoProdutoRequisicaoListaMaterial

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Se for ferramnenta
            If sGrupoItemFerramentaConcatenado <> "" Then

                txtCodigoProdutoNovoRequisicaoListaMaterial.Text = LoadCodigo("sp_select_cadastro_basico_grupo_item_concatenado_ferramenta " & goUsuario.iEmpresa & "," & "'" & sGrupoItemFerramentaConcatenado & "','CODIGO'")
                txtDescricaoRequisicaoListaMaterial.Text = LoadCodigo("sp_select_cadastro_basico_grupo_item_concatenado_ferramenta " & goUsuario.iEmpresa & "," & "'" & sGrupoItemFerramentaConcatenado & "','DESCRIÇÃO'")

            End If

            LiberaTipoRequisicao()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboGrupoItem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboGrupoItemRequisicaoListaMaterial.SelectedIndexChanged
        Try

            If cboGrupoItemRequisicaoListaMaterial.SelectedIndex = -1 Then Exit Sub

            txtDescricaoRequisicaoListaMaterial.Text = LoadCodigo("sp_select_cadastro_basico_grupo_item_composicao " & cboGrupoItemRequisicaoListaMaterial.SelectedValue & "," & goUsuario.iEmpresa & ",'SIGLA'")
            txtCodigoProdutoNovoRequisicaoListaMaterial.Text = LoadCodigo("sp_select_cadastro_basico_grupo_item_composicao " & cboGrupoItemRequisicaoListaMaterial.SelectedValue & "," & goUsuario.iEmpresa & ",'CODIGO'")
            txtProdutoNovoCorte.Text = LoadCodigo("sp_select_cadastro_basico_grupo_item_composicao " & cboGrupoItemRequisicaoListaMaterial.SelectedValue & "," & goUsuario.iEmpresa & ",'CODIGO'")

            Dim iCodigoMaterial As Integer
            Dim icodigoTipoPerfil As Integer

            'Carrega os dados baseado na estrutura de grupo de item
            LoadDadosGrupoItem(cboGrupoItemRequisicaoListaMaterial.SelectedValue,
                               iCodigoTipoPerfil:=icodigoTipoPerfil,
                               iCodigoMaterial:=iCodigoMaterial,
                               iCodigoFamilia:=-1,
                               iCodigoTipoItemSPED:=-1)

            cboGrupoItemRequisicaoListaMaterial.Tag = CStr(icodigoTipoPerfil) & "|" & CStr(iCodigoMaterial)

            LoadMaterial()

            LoadTipoPerfil()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub cboCodigoProdutoRequisicaoListaMaterial_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCodigoProdutoRequisicaoListaMaterial.SelectedIndexChanged
        Try

            If cboCodigoProdutoRequisicaoListaMaterial.SelectedIndex = -1 Then

                lblCodigoProdutoNovoRequisicaoListaMaterial.Visible = True : txtCodigoProdutoNovoRequisicaoListaMaterial.Visible = True
                Exit Sub

            End If

            lblCodigoProdutoNovoRequisicaoListaMaterial.Visible = False : txtCodigoProdutoNovoRequisicaoListaMaterial.Visible = False
            txtDescricaoRequisicaoListaMaterial.Text = LoadCodigo("sp_load_cadastro_basico_produto_descricao " & cboCodigoProdutoRequisicaoListaMaterial.SelectedValue & "," & goUsuario.iEmpresa)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try
    End Sub

    Private Sub Peso_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtQuantidadeRequisicaoListaMaterial.LostFocus,
                                                                                            txtMedida1.LostFocus,
                                                                                            txtMedida2.LostFocus,
                                                                                            txtMedida3.LostFocus,
                                                                                            txtMedida4.LostFocus

        Try

            CalculaPesoTeorico(1)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

#End Region

#Region "::: CORTE :::"

    Private Sub PesoCorte_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtQuantidadeCorte.LostFocus,
                                                                                                 txtMedida1Corte.LostFocus,
                                                                                                 txtMedida2Corte.LostFocus,
                                                                                                 txtMedida3Corte.LostFocus,
                                                                                                 txtMedida4Corte.LostFocus

        Try

            CalculaPesoTeorico(2)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
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


            LoadCombo(cboGrupoItemRequisicaoListaMaterial, "sp_select_combo_cadastro_basico_grupo_item " & goUsuario.iEmpresa)
            LoadCombo(cboTipoRequisicao, "sp_select_combo_tipo_requisicao_material " & 1)
            LoadCombo(cboCodigoProdutoRequisicaoListaMaterial, "sp_select_combo_cadastro_basico_item " & goUsuario.iEmpresa & ",null, null, -1")
            LoadCombo(cboUnidadeMedida, "sp_select_combo_cadastro_basico_unidade_medida_orcamento " & goUsuario.iEmpresa)
            LoadCombo(cboUnidadeMedidaCorte, "sp_select_combo_cadastro_basico_unidade_medida_orcamento " & goUsuario.iEmpresa)

            dtpDataNecessidade.Value = Now

            txtDescricaoRequisicaoListaMaterial.ReadOnly = True
            txtQuantidadeRequisicaoListaMaterial.Value = 1

            If Len(cboGrupoItemRequisicaoListaMaterial.Tag) > 0 Then
                cboGrupoItemRequisicaoListaMaterial.SelectedValue = cboGrupoItemRequisicaoListaMaterial.Tag
            End If

            If Len(cboCodigoProdutoRequisicaoListaMaterial.Tag) > 0 Then
                cboCodigoProdutoRequisicaoListaMaterial.SelectedValue = cboCodigoProdutoRequisicaoListaMaterial.Tag
            End If

            If Len(cboUnidadeMedida.Tag) > 0 Then
                cboUnidadeMedida.SelectedValue = cboUnidadeMedida.Tag
            End If

            If Len(txtMedida1.Tag) > 0 Then
                txtMedida1.Value = txtMedida1.Tag
            End If

            If Len(txtMedida2.Tag) > 0 Then
                txtMedida2.Value = txtMedida2.Tag
            End If

            If Len(txtMedida3.Tag) > 0 Then
                txtMedida3.Value = txtMedida3.Tag
            End If

            If Len(txtMedida4.Tag) > 0 Then
                txtMedida4.Value = txtMedida4.Tag
            End If

            If Len(txtPeso.Tag) > 0 Then
                txtPeso.Value = txtPeso.Tag
            End If

            ExibirCorteMaterial(False)

            cboTipoRequisicao.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

#End Region

#Region "::: LISTA DE MATERIAL :::"

    Private Function ValidacaoRequisicao() As Boolean

        Try

            ValidacaoRequisicao = False

            If ValidaCampo(cboGrupoItemRequisicaoListaMaterial, lblGrupoItemRequisicaoListaMaterial) = False Then Exit Function

            If ValidaCampo(cboTipoRequisicao, lblTipoRequisicao) = False Then Exit Function

            If ValidaCampo(txtQuantidadeRequisicaoListaMaterial, lblQuantidadeRequisicaoListaMaterial, True) = False Then Exit Function

            If ValidaCampo(cboUnidadeMedida, lblUnidadeMedida) = False Then Exit Function

            'Se não foi selecionado o produto
            If cboCodigoProdutoRequisicaoListaMaterial.SelectedIndex = -1 Then
                'Verifica se a Descrição Preenchida é Válida
                If oClsPrdOrdemProducao.ValidaItemRequisicao(cboGrupoItemRequisicaoListaMaterial.SelectedValue,
                                                             txtMedida1.Value,
                                                             txtMedida2.Value,
                                                             txtMedida3.Value,
                                                             txtMedida4.Value) = False Then
                    frmMain.errInfo.SetError(lblDescricaoRequisicaoListaMaterial, "Esta Item: " & txtDescricaoRequisicaoListaMaterial.Text & " já está associado a outro item cadastrado.")
                    txtDescricaoRequisicaoListaMaterial.Focus()
                    Exit Function
                End If
            End If

            'If txtQuantidadePlanejada.Value > txtQuantidadeRequisicaoListaMaterial.Value Then
            '    If MsgBox("A quantidade planejada é maior que a quantidade requisitada. Deseja continuar?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Text) <> MsgBoxResult.Yes Then Exit Function
            'End If

            If ValidaQuantidadeEstoque(cboCodigoProdutoRequisicaoListaMaterial.SelectedValue, txtQuantidadeRequisicaoListaMaterial.Value, cboTipoRequisicao.SelectedValue) = False Then Exit Function

            ValidacaoRequisicao = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function ValidaQuantidadeEstoque(ByVal iCodigoProduto As Integer, _
                                            ByVal dQuantidade As Double,
                                            ByVal iTipoRequisicao As Integer) As Boolean

        Try

            Dim bReturn As Boolean = False

            bReturn = oClsPrdOrdemProducao.ValidateQuantidadeEstoque(iCodigoProduto, _
                                                                     dQuantidade)

            If bReturn And iTipoRequisicao <> 1 = False Then
                MsgBox("A quantidade solicitada é menor que a presente no estoque!", MsgBoxStyle.Exclamation, "Validação")
                Return bReturn
            End If

            Return True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub LoadTipoPerfil()

        Try

            txtMedida1.Enabled = False : txtMedida1.Value = 0
            txtMedida2.Enabled = False : txtMedida2.Value = 0
            txtMedida3.Enabled = False : txtMedida3.Value = 0
            txtMedida4.Enabled = False : txtMedida4.Value = 0

            CalculaPesoTeorico(1)

            LoadMedidas(1)

            CalculaPesoTeorico(1)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Function ObterGrupo(texto As String) As String

        Try

            Dim ultimaBarra As Integer = texto.LastIndexOf("/")

            If ultimaBarra >= 0 Then
                Dim ultimaParte As String = texto.Substring(ultimaBarra + 1).Trim()
                Return ultimaParte
            Else
                Return texto
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub LoadMedidas(ByVal iTipo As Integer)
        Try

            'TIPOS: 1 - PRODUTO ORIGEM
            '       2 - CORTE

            Dim sCodigoTipoPerfil As String = -1

            Dim lCodigoItem As Long
            Dim dMedida1 As Double
            Dim dMedida2 As Double
            Dim dMedida3 As Double
            Dim dMedida4 As Double
            Dim iCodigoUnidadeMedida As Integer
            Dim sGrupoItemFinal As String = ObterGrupo(cboGrupoItemRequisicaoListaMaterial.Text)

            Try
                sCodigoTipoPerfil = cboGrupoItemRequisicaoListaMaterial.Tag.ToString.Split("|")(0)
                If sCodigoTipoPerfil = "-1" Then Exit Sub
            Catch ex As Exception
                Throw ex
            End Try

            Dim iQuantidadeMedidas As Integer = LoadCodigo("sp_load_cadastro_basico_tipo_perfil_quantidade_medidas " & sCodigoTipoPerfil & "," & goUsuario.iEmpresa)
            Dim sMedida1 As String = LoadCodigo("sp_load_cadastro_basico_tipo_perfil_descricao_medida " & sCodigoTipoPerfil & ", 1, " & goUsuario.iEmpresa)
            Dim sMedida2 As String = LoadCodigo("sp_load_cadastro_basico_tipo_perfil_descricao_medida " & sCodigoTipoPerfil & ", 2, " & goUsuario.iEmpresa)
            Dim sMedida3 As String = LoadCodigo("sp_load_cadastro_basico_tipo_perfil_descricao_medida " & sCodigoTipoPerfil & ", 3, " & goUsuario.iEmpresa)
            Dim sMedida4 As String = LoadCodigo("sp_load_cadastro_basico_tipo_perfil_descricao_medida " & sCodigoTipoPerfil & ", 4, " & goUsuario.iEmpresa)

            If iTipo = 1 Then

                lCodigoItem = IIf(cboCodigoProdutoRequisicaoListaMaterial.SelectedIndex = -1, -1, cboCodigoProdutoRequisicaoListaMaterial.SelectedValue)
                'Se tiver selecionado um item, bloqueia todas as medidas 
                If lCodigoItem <> -1 Then HabilitarMedidas(False) Else HabilitarMedidas(True)

                dMedida1 = LoadCodigo("sp_load_cadastro_basico_produto_medida " & lCodigoItem & "," & goUsuario.iEmpresa & "," & 1)
                dMedida2 = LoadCodigo("sp_load_cadastro_basico_produto_medida " & lCodigoItem & "," & goUsuario.iEmpresa & "," & 2)
                dMedida3 = LoadCodigo("sp_load_cadastro_basico_produto_medida " & lCodigoItem & "," & goUsuario.iEmpresa & "," & 3)
                dMedida4 = LoadCodigo("sp_load_cadastro_basico_produto_medida " & lCodigoItem & "," & goUsuario.iEmpresa & "," & 4)
                iCodigoUnidadeMedida = LoadCodigo("sp_load_cadastro_basico_produto_medida " & lCodigoItem & "," & goUsuario.iEmpresa & "," & 5)

                Select Case iQuantidadeMedidas

                    Case 1
                        txtMedida1.Enabled = True
                        lblMedida1.Text = sMedida1 + ":"

                        If IsNumeric(dMedida1) And dMedida1 > 0 Then

                            txtMedida1.Value = dMedida1

                        ElseIf IsNumeric(sGrupoItemFinal) Then

                            txtMedida1.ReadOnly = True
                            txtMedida1.BackColor = Color.WhiteSmoke
                            txtMedida1.Text = Convert.ToDouble(sGrupoItemFinal.Replace(",", "."), CultureInfo.InvariantCulture)

                        End If

                    Case 2
                        txtMedida1.Enabled = True
                        txtMedida2.Enabled = True

                        lblMedida1.Text = sMedida1 + ":"
                        lblMedida2.Text = sMedida2 + ":"

                        If IsNumeric(dMedida1) And dMedida1 > 0 Then

                            txtMedida1.Value = dMedida1

                        ElseIf IsNumeric(sGrupoItemFinal) Then

                            txtMedida1.ReadOnly = True
                            txtMedida1.BackColor = Color.WhiteSmoke
                            txtMedida1.Text = Convert.ToDouble(sGrupoItemFinal.Replace(",", "."), CultureInfo.InvariantCulture)

                        End If

                        If IsNumeric(dMedida2) And dMedida2 > 0 Then
                            txtMedida2.Value = dMedida2
                        End If

                    Case 3
                        txtMedida1.Enabled = True
                        txtMedida2.Enabled = True
                        txtMedida3.Enabled = True

                        lblMedida1.Text = sMedida1 + ":"
                        lblMedida2.Text = sMedida2 + ":"
                        lblMedida3.Text = sMedida3 + ":"

                        If IsNumeric(dMedida1) And dMedida1 > 0 Then

                            txtMedida1.Value = dMedida1

                        ElseIf IsNumeric(sGrupoItemFinal) Then

                            txtMedida1.ReadOnly = True
                            txtMedida1.BackColor = Color.WhiteSmoke
                            txtMedida1.Text = Convert.ToDouble(sGrupoItemFinal.Replace(",", "."), CultureInfo.InvariantCulture)

                        End If

                        If IsNumeric(dMedida2) And dMedida2 > 0 Then
                            txtMedida2.Value = dMedida2
                        End If

                        If IsNumeric(dMedida3) And dMedida3 > 0 Then
                            txtMedida3.Value = dMedida3
                        End If

                    Case 4
                        txtMedida1.Enabled = True
                        txtMedida2.Enabled = True
                        txtMedida3.Enabled = True
                        txtMedida4.Enabled = True

                        lblMedida1.Text = sMedida1 + ":"
                        lblMedida2.Text = sMedida2 + ":"
                        lblMedida3.Text = sMedida3 + ":"
                        lblMedida4.Text = sMedida4 + ":"

                        If IsNumeric(dMedida1) And dMedida1 > 0 Then

                            txtMedida1.Value = dMedida1

                        ElseIf IsNumeric(sGrupoItemFinal) Then

                            txtMedida1.ReadOnly = True
                            txtMedida1.BackColor = Color.WhiteSmoke
                            txtMedida1.Text = Convert.ToDouble(sGrupoItemFinal.Replace(",", "."), CultureInfo.InvariantCulture)

                        End If

                        If IsNumeric(dMedida2) And dMedida2 > 0 Then
                            txtMedida2.Value = dMedida2
                        End If

                        If IsNumeric(dMedida3) And dMedida3 > 0 Then
                            txtMedida3.Value = dMedida3
                        End If

                        If IsNumeric(dMedida4) And dMedida4 > 0 Then
                            txtMedida4.Value = dMedida4
                        End If

                End Select

            ElseIf iTipo = 2 Then

                Select Case iQuantidadeMedidas

                    Case 1

                        lblMedida1Corte.Text = sMedida1 + ":"

                        txtMedida1Corte.ReadOnly = True
                        txtMedida1Corte.BackColor = Color.WhiteSmoke
                        txtMedida1Corte.Value = txtMedida1.Value

                    Case 2

                        txtMedida1Corte.Enabled = True
                        txtMedida2Corte.Enabled = True

                        lblMedida1Corte.Text = sMedida1 + ":"
                        lblMedida2Corte.Text = sMedida2 + ":"

                        txtMedida1Corte.ReadOnly = True
                        txtMedida1Corte.BackColor = Color.WhiteSmoke
                        txtMedida1Corte.Value = txtMedida1.Value


                    Case 3

                        txtMedida2Corte.Enabled = True
                        txtMedida3Corte.Enabled = True

                        lblMedida1Corte.Text = sMedida1 + ":"
                        lblMedida2Corte.Text = sMedida2 + ":"
                        lblMedida3Corte.Text = sMedida3 + ":"

                        txtMedida1Corte.ReadOnly = True
                        txtMedida1Corte.BackColor = Color.WhiteSmoke
                        txtMedida1Corte.Value = txtMedida1.Value

                    Case 4

                        txtMedida2Corte.Enabled = True
                        txtMedida3Corte.Enabled = True
                        txtMedida4Corte.Enabled = True

                        lblMedida1Corte.Text = sMedida1 + ":"
                        lblMedida2Corte.Text = sMedida2 + ":"
                        lblMedida3Corte.Text = sMedida3 + ":"
                        lblMedida4Corte.Text = sMedida4 + ":"

                        txtMedida1Corte.ReadOnly = True
                        txtMedida1Corte.BackColor = Color.WhiteSmoke
                        txtMedida1Corte.Value = txtMedida1.Value

                End Select

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub LoadMaterial()

        Try

            txtPesoEspecifico.Value = 0

            Dim sCodigoMaterial As String = -1
            Try
                sCodigoMaterial = cboGrupoItemRequisicaoListaMaterial.Tag.ToString.Split("|")(1)
            Catch ex As Exception

            End Try

            If sCodigoMaterial = "-1" Then Exit Sub

            txtPesoEspecifico.Value = LoadCodigo("sp_load_cadastro_basico_material_densidade " & sCodigoMaterial & "," & goUsuario.iEmpresa)
            txtPesoEspecificoCorte.Value = LoadCodigo("sp_load_cadastro_basico_material_densidade " & sCodigoMaterial & "," & goUsuario.iEmpresa)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub CalculaPesoTeorico(ByVal iTipo As Integer)
        Try


            If cboGrupoItemRequisicaoListaMaterial.Tag Is Nothing OrElse String.IsNullOrEmpty(cboGrupoItemRequisicaoListaMaterial.Tag.ToString()) Then
                Exit Sub
            End If

            Dim sCodigoTipoPerfil As String = cboGrupoItemRequisicaoListaMaterial.Tag.ToString().Split("|")(0)
            If sCodigoTipoPerfil = "-1" Then
                If cboCodigoProdutoRequisicaoListaMaterial.SelectedIndex <> -1 Then
                    txtDescricaoRequisicaoListaMaterial.Text = LoadCodigo("sp_load_cadastro_basico_produto_descricao " & cboCodigoProdutoRequisicaoListaMaterial.SelectedValue & ", " & goUsuario.iEmpresa)
                End If
                Exit Sub
            End If

            Dim sFormula As String = LoadCodigo("sp_load_cadastro_basico_tipo_perfil_formula " & sCodigoTipoPerfil & ", " & goUsuario.iEmpresa)
            Dim dQuantidade As Double
            Dim dMedida1 As Double
            Dim dMedida2 As Double
            Dim dMedida3 As Double
            Dim dMedida4 As Double
            Dim dPesoEspecifico As Double

            'TIPOS: 1 - PRODUTO ORIGEM
            '       2 - CORTE
            If iTipo = 1 Then
                dQuantidade = txtQuantidadeRequisicaoListaMaterial.Value
                dMedida1 = txtMedida1.Value
                dMedida2 = txtMedida2.Value
                dMedida3 = txtMedida3.Value
                dMedida4 = txtMedida4.Value
                dPesoEspecifico = txtPesoEspecifico.Value
            ElseIf iTipo = 2 Then
                dQuantidade = txtQuantidadeCorte.Value
                dMedida1 = txtMedida1Corte.Value
                dMedida2 = txtMedida2Corte.Value
                dMedida3 = txtMedida3Corte.Value
                dMedida4 = txtMedida4Corte.Value
                dPesoEspecifico = txtPesoEspecificoCorte.Value
            End If

            Dim sCalculo As String = PreparaCalculo(sFormula,
                                                    dMedida1,
                                                    dMedida2,
                                                    dMedida3,
                                                    dMedida4,
                                                    dPesoEspecifico)

            Dim dPesoCalculado As Double = EvalFormula(sCalculo) * dQuantidade

            If iTipo = 1 Then
                txtPeso.Value = dPesoCalculado
                txtDescricaoRequisicaoListaMaterial.Text = PreparaDescricao(dMedida1,
                                                                            dMedida2,
                                                                            dMedida3,
                                                                            dMedida4,
                                                                            dQuantidade,
                                                                            dPesoCalculado,
                                                                            cboGrupoItemRequisicaoListaMaterial.SelectedValue)
            ElseIf iTipo = 2 Then
                txtPesoCorte.Value = dPesoCalculado
                txtDescricaoCorte.Text = PreparaDescricao(dMedida1,
                                                          dMedida2,
                                                          dMedida3,
                                                          dMedida4,
                                                          dQuantidade,
                                                          dPesoCalculado,
                                                          cboGrupoItemRequisicaoListaMaterial.SelectedValue)

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function PreparaCalculo(ByVal sFormula As String,
                                    ByVal dMedida1 As Double,
                                    ByVal dMedida2 As Double,
                                    ByVal dMedida3 As Double,
                                    ByVal dMedida4 As Double,
                                    ByVal dPesoEspecifico As Double) As String

        Try

            Dim sCalculo As String = sFormula
            sCalculo = sCalculo.Replace("|MEDIDA_1|", dMedida1.ToString())
            sCalculo = sCalculo.Replace("|MEDIDA_2|", dMedida2.ToString())
            sCalculo = sCalculo.Replace("|MEDIDA_3|", dMedida3.ToString())
            sCalculo = sCalculo.Replace("|MEDIDA_4|", dMedida4.ToString())
            sCalculo = sCalculo.Replace("|PESO_ESP|", dPesoEspecifico.ToString())
            sCalculo = sCalculo.Replace(",", ".")
            Return sCalculo

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Function EvalFormula(ByVal sCalculo As String) As Double

        Try

            Dim oScriptControl As New MSScriptControl.ScriptControl
            oScriptControl.Language = "VBScript"
            Return oScriptControl.Eval(sCalculo)

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Function PreparaDescricao(ByVal dMedida1 As Double,
                                      ByVal dMedida2 As Double,
                                      ByVal dMedida3 As Double,
                                      ByVal dMedida4 As Double,
                                      ByVal dQuantidade As Double,
                                      ByVal dPesoCalculado As Double,
                                      ByVal sGrupoItem As String) As String

        Try

            Dim descricao As String = LoadCodigo("sp_select_cadastro_basico_grupo_item_composicao " & sGrupoItem & ", " & goUsuario.iEmpresa & ", " & "SIGLA")

            'Solicitatção Chamado 6323
            If dMedida1 > 0.0 Then
                If dMedida2 = 0.0 AndAlso dMedida3 = 0.0 AndAlso dMedida4 = 0.0 Then
                    ' Se houver apenas a primeira medida, usa " X "
                    descricao &= " X " & FormatNumber(dMedida1, 2)
                Else
                    ' Se houver mais medidas, usa " - " para a primeira
                    descricao &= " - " & FormatNumber(dMedida1, 2)
                End If
            End If

            descricao &= If(dMedida2 > 0.0, " X " & FormatNumber(dMedida2, 2), "")
            descricao &= If(dMedida3 > 0.0, " X " & FormatNumber(dMedida3, 2), "")
            descricao &= If(dMedida4 > 0.0, " X " & FormatNumber(dMedida4, 2), "")

            If dQuantidade > 0 Then
                descricao &= If(dPesoCalculado > 0.0, "(" & FormatNumber(dPesoCalculado / dQuantidade, 2) & " KG )", "")
            End If
            Return descricao

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub SalvarRequisicaoCompra()

        Try
            'Limpa os erros
            frmMain.errInfo.Clear()


            'Se não foi selecionado o produto
            If cboCodigoProdutoRequisicaoListaMaterial.SelectedIndex = -1 Then

                'Cadastrar o item
                Dim lCodigoItem As Long = oClsPrdOrdemProducao.InsertCadastroBasicoProdutoOP(cboGrupoItemRequisicaoListaMaterial.SelectedValue,
                                                                                      txtDescricaoRequisicaoListaMaterial.Text.Trim,
                                                                                      txtCodigoProdutoNovoRequisicaoListaMaterial.Text,
                                                                                      txtMedida1.Value,
                                                                                      txtMedida2.Value,
                                                                                      txtMedida3.Value,
                                                                                      txtMedida4.Value,
                                                                                      cboUnidadeMedida.SelectedValue,
                                                                                      -1,
                                                                                      "")

                LoadCombo(cboCodigoProdutoRequisicaoListaMaterial, "sp_select_combo_cadastro_basico_item " & goUsuario.iEmpresa & ",null, null, -1")
                cboCodigoProdutoRequisicaoListaMaterial.SelectedValue = lCodigoItem

            End If

            'Verifica se é uma edição, se for vai excluir atual e criar uma nova
            If IsNumeric(lCodigoRequisicaoItem) Then
                oClsPrdOrdemProducao.DeleteRequisicaoItemListaMaterial(lCodigoRequisicao, lCodigoRequisicaoItem)
            End If

            'Insere 
            btnSalvarRequisicao.Tag = oClsPrdOrdemProducao.InsertRequisicaoItem(lCodigoRequisicao)

            'Atualiza os dados de requisição
            oClsPrdOrdemProducao.UpdateRequisicaoEstoque(iCodigoRequisicao:=lCodigoRequisicao,
                                                         iCodigoRequisicaoItem:=btnSalvarRequisicao.Tag,
                                                         iCodigoGrupoItem:=cboGrupoItemRequisicaoListaMaterial.SelectedValue,
                                                         iCodigoItem:=cboCodigoProdutoRequisicaoListaMaterial.SelectedValue,
                                                         dQuantidade:=txtQuantidadeRequisicaoListaMaterial.Value,
                                                         dMedida1:=txtMedida1.Value,
                                                         dMedida2:=txtMedida2.Value,
                                                         dMedida3:=txtMedida3.Value,
                                                         dMedida4:=txtMedida4.Value,
                                                         dPeso:=txtPeso.Value,
                                                         iCodigoUnidadeMedida:=IIf(cboUnidadeMedida.SelectedIndex = -1, -1, cboUnidadeMedida.SelectedValue),
                                                         sCodigoProduto:=txtCodigoProdutoNovoRequisicaoListaMaterial.Text,
                                                         sDescricao:=txtDescricaoRequisicaoListaMaterial.Text.Trim,
                                                         iCodigoTipoItemRequisicao:=2,
                                                         bItemCompra:=True,
                                                         sDataNecessidade:=dtpDataNecessidade.Value,
                                                         sObservacao:=txtObservacao.Text,
                                                         sObservacaoInterna:=txtObservacaoInterna.Text,
                                                         sReferenciaEstrutura:=txtNumeroDesenho.Text.Trim)




            'Informa o usuário
            frmMain.Informacao(Mensagem.RegistroAlterado)


        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub SalvarRequisicaoEstoque()

        Try
            'Limpa os erros
            frmMain.errInfo.Clear()


            'Se não foi selecionado o produto
            If cboCodigoProdutoRequisicaoListaMaterial.SelectedIndex = -1 Then



                'Cadastrar o item
                Dim lCodigoItem As Long = oClsPrdOrdemProducao.InsertCadastroBasicoProdutoOP(cboGrupoItemRequisicaoListaMaterial.SelectedValue,
                                                                                      txtDescricaoRequisicaoListaMaterial.Text.Trim,
                                                                                      txtCodigoProdutoNovoRequisicaoListaMaterial.Text,
                                                                                      txtMedida1.Value,
                                                                                      txtMedida2.Value,
                                                                                      txtMedida3.Value,
                                                                                      txtMedida4.Value,
                                                                                      cboUnidadeMedida.SelectedValue,
                                                                                      -1,
                                                                                      "")

                LoadCombo(cboCodigoProdutoRequisicaoListaMaterial, "sp_select_combo_cadastro_basico_item " & goUsuario.iEmpresa & ",null, null, -1")
                cboCodigoProdutoRequisicaoListaMaterial.SelectedValue = lCodigoItem

            End If

            'Verifica se é uma edição, se for vai excluir atual e criar uma nova
            If IsNumeric(lCodigoRequisicaoItem) Then
                oClsPrdOrdemProducao.DeleteRequisicaoItemListaMaterial(lCodigoRequisicao, lCodigoRequisicaoItem)
            End If

            'Insere 
            btnSalvarRequisicao.Tag = oClsPrdOrdemProducao.InsertRequisicaoItem(lCodigoRequisicao)


            'Atualiza os dados de requisição
            oClsPrdOrdemProducao.UpdateRequisicaoEstoque(iCodigoRequisicao:=lCodigoRequisicao,
                                                         iCodigoRequisicaoItem:=btnSalvarRequisicao.Tag,
                                                         iCodigoGrupoItem:=cboGrupoItemRequisicaoListaMaterial.SelectedValue,
                                                         iCodigoItem:=cboCodigoProdutoRequisicaoListaMaterial.SelectedValue,
                                                         dQuantidade:=txtQuantidadeRequisicaoListaMaterial.Value,
                                                         dMedida1:=txtMedida1.Value,
                                                         dMedida2:=txtMedida2.Value,
                                                         dMedida3:=txtMedida3.Value,
                                                         dMedida4:=txtMedida4.Value,
                                                         dPeso:=txtPeso.Value,
                                                         iCodigoUnidadeMedida:=IIf(cboUnidadeMedida.SelectedIndex = -1, -1, cboUnidadeMedida.SelectedValue),
                                                         sCodigoProduto:=txtCodigoProdutoNovoRequisicaoListaMaterial.Text,
                                                         sDescricao:=txtDescricaoRequisicaoListaMaterial.Text.Trim,
                                                         iCodigoTipoItemRequisicao:=2,
                                                         bItemCompra:=False,
                                                         sDataNecessidade:=dtpDataNecessidade.Value,
                                                         sObservacao:=txtObservacao.Text,
                                                         sObservacaoInterna:=txtObservacaoInterna.Text,
                                                         sReferenciaEstrutura:=txtNumeroDesenho.Text.Trim)

            'Informa o usuário
            frmMain.Informacao(Mensagem.RegistroAlterado)


        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub LimparCampos()
        Try

            cboGrupoItemRequisicaoListaMaterial.SelectedIndex = -1
            cboGrupoItemRequisicaoListaMaterial.Tag = ""
            cboCodigoProdutoRequisicaoListaMaterial.SelectedIndex = -1
            cboCodigoProdutoRequisicaoListaMaterial.Tag = ""
            txtQuantidadeEstoque.Value = 0
            cboUnidadeMedidaEstoque.SelectedIndex = -1
            txtCodigoProdutoNovoRequisicaoListaMaterial.Text = ""
            txtQuantidadeRequisicaoListaMaterial.Value = 1
            dtpDataNecessidade.Value = Date.Now
            txtMedida1.Value = 0
            txtMedida2.Value = 0
            txtMedida3.Value = 0
            txtMedida4.Value = 0
            cboUnidadeMedida.SelectedIndex = -1
            txtPesoEspecifico.Value = 0
            txtPeso.Value = 0
            txtDescricaoRequisicaoListaMaterial.Text = ""
            txtObservacao.Text = ""
            txtObservacaoInterna.Text = ""
            cboTipoRequisicao.SelectedIndex = -1

            LimparCamposGroupBox(grpCorteMaterial)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub HabilitarMedidas(ByVal bHabilitar As Boolean)

        Try

            If bHabilitar = True Then

                txtMedida1.ReadOnly = False
                txtMedida1.BackColor = Color.White

                txtMedida2.ReadOnly = False
                txtMedida2.BackColor = Color.White

                txtMedida3.ReadOnly = False
                txtMedida3.BackColor = Color.White

                txtMedida4.ReadOnly = False
                txtMedida4.BackColor = Color.White

            Else

                'Bloquea os campos de medida
                txtMedida1.ReadOnly = True
                txtMedida1.BackColor = Color.WhiteSmoke

                txtMedida2.ReadOnly = True
                txtMedida2.BackColor = Color.WhiteSmoke

                txtMedida3.ReadOnly = True
                txtMedida3.BackColor = Color.WhiteSmoke

                txtMedida4.ReadOnly = True
                txtMedida4.BackColor = Color.WhiteSmoke

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub


    Private Sub LiberaTipoRequisicao()
        Try

            LoadCombo(cboTipoRequisicao, "sp_select_combo_tipo_requisicao_material " & 1)
            cboTipoRequisicao.SelectedValue = 1
            cboTipoRequisicao.Enabled = False

            If cboGrupoItemRequisicaoListaMaterial.SelectedValue = 2750 Then '2750: 99 - MATERIAL DE TERCEIRO
                cboTipoRequisicao.SelectedValue = 2
                cboTipoRequisicao.Enabled = False
                Exit Sub
            End If

            If Not String.IsNullOrEmpty(cboCodigoProdutoRequisicaoListaMaterial.Tag) AndAlso IsNumeric(cboCodigoProdutoRequisicaoListaMaterial.Tag) AndAlso CDbl(cboCodigoProdutoRequisicaoListaMaterial.Tag) > 0 Then

                LoadCombo(cboTipoRequisicao, "sp_select_combo_tipo_requisicao_material " & 2)
                cboTipoRequisicao.SelectedIndex = -1
                cboTipoRequisicao.Enabled = True

            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub


#End Region

#Region "::: CORTE :::"

    Private Sub ExibirCorteMaterial(ByVal bExibir As Boolean)
        Try


            If bExibir = True Then

                'Garante que o componente NÃO está visível antes de redimensionar 
                If grpCorteMaterial.Visible = False Then
                    grpCorteMaterial.Visible = True
                    Me.Height = Me.Height + (grpCorteMaterial.Size.Height + 6) '6 é a margem
                End If

            Else

                'Garante que o componente está visível antes de redimensionar  
                If grpCorteMaterial.Visible = True Then
                    grpCorteMaterial.Visible = False
                    Me.Height = Me.Height - (grpCorteMaterial.Size.Height + 6) '6 é a margem
                End If

            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub LoadTipoPerfilCorte()

        Try

            txtMedida1Corte.Enabled = False : txtMedida1Corte.Value = 0
            txtMedida2Corte.Enabled = False : txtMedida2Corte.Value = 0
            txtMedida3Corte.Enabled = False : txtMedida3Corte.Value = 0
            txtMedida4Corte.Enabled = False : txtMedida4Corte.Value = 0

            CalculaPesoTeorico(2)

            LoadMedidas(2)

            CalculaPesoTeorico(2)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Function ValidacaoRequisicaoCorte() As Boolean

        Try

            ValidacaoRequisicaoCorte = False


            If (cboCodigoProdutoRequisicaoListaMaterial.SelectedIndex = -1) = True Then
                frmMain.errInfo.SetError(lblCodigoProdutoNovoRequisicaoListaMaterial, "Não é Possível Cortar um Porduto Novo.")
                Exit Function
            End If

            If (txtQuantidadeCorte.Value <= 0) = True Then
                frmMain.errInfo.SetError(lblQuantidadeCorte, "A Quantidade deve ser maior que ZERO.")
                txtQuantidadeCorte.Focus()
                Exit Function
            End If

            If ValidaCampo(cboUnidadeMedidaCorte, lblUnidadeMedidaCorte) = False Then Exit Function

            If (txtMedida1.Value >= txtMedida1Corte.Value) = False Then
                frmMain.errInfo.SetError(lblMedida1Corte, lblMedida1Corte.Text & " Do Corte é maior que a original.")
                txtMedida1Corte.Focus()
                Exit Function
            End If

            If (txtMedida2.Value >= txtMedida2Corte.Value) = False Then
                frmMain.errInfo.SetError(lblMedida2Corte, lblMedida2Corte.Text & " Do Corte é maior que a original.")
                txtMedida2Corte.Focus()
                Exit Function
            End If

            If (txtMedida3.Value >= txtMedida3Corte.Value) = False Then
                frmMain.errInfo.SetError(lblMedida3Corte, lblMedida3Corte.Text & " Do Corte é maior que a original.")
                txtMedida3Corte.Focus()
                Exit Function
            End If

            If (txtMedida4.Value >= txtMedida4Corte.Value) = False Then
                frmMain.errInfo.SetError(lblMedida4Corte, lblMedida4Corte.Text & " Do Corte é maior que a original.")
                txtMedida4Corte.Focus()
                Exit Function
            End If


            ValidacaoRequisicaoCorte = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub SalvarRequisicaoCorte()

        Try
            'Limpa os erros
            frmMain.errInfo.Clear()

            Dim lCodigoItem As Long = LoadCodigo("sp_load_lista_material_codigo_item_medidas " &
                                     cboGrupoItemRequisicaoListaMaterial.SelectedValue & ", " &
                                     txtMedida1Corte.Value.ToString().Replace(",", ".") & ", " &
                                     txtMedida2Corte.Value.ToString().Replace(",", ".") & ", " &
                                     txtMedida3Corte.Value.ToString().Replace(",", ".") & ", " &
                                     txtMedida4Corte.Value.ToString().Replace(",", ".") & ", " &
                                     goUsuario.iEmpresa)

            Dim sCodigoProduto As String = LoadCodigo("sp_load_lista_material_codigo_produto " & lCodigoItem & ", " & goUsuario.iEmpresa)

            If lCodigoItem = -1 Then

                'Cadastrar o item e altera o valor da variavel
                lCodigoItem = oClsPrdOrdemProducao.InsertCadastroBasicoProdutoOP(cboGrupoItemRequisicaoListaMaterial.SelectedValue,
                                                                                 txtDescricaoCorte.Text.Trim,
                                                                                 txtProdutoNovoCorte.Text,
                                                                                 txtMedida1Corte.Value,
                                                                                 txtMedida2Corte.Value,
                                                                                 txtMedida3Corte.Value,
                                                                                 txtMedida4Corte.Value,
                                                                                 cboUnidadeMedidaCorte.SelectedValue,
                                                                                 -1,
                                                                                 "")
                sCodigoProduto = txtProdutoNovoCorte.Text

            End If

            'Verifica se é uma edição, se for vai excluir atual e criar uma nova
            If IsNumeric(lCodigoRequisicaoItem) Then
                oClsPrdOrdemProducao.DeleteRequisicaoItemListaMaterial(lCodigoRequisicao, lCodigoRequisicaoItem)
            End If

            'Insere 
            btnSalvarRequisicao.Tag = oClsPrdOrdemProducao.InsertRequisicaoItem(lCodigoRequisicao)

            'Atualiza os dados de requisição
            oClsPrdOrdemProducao.UpdateRequisicaoEstoque(iCodigoRequisicao:=lCodigoRequisicao,
                                                         iCodigoRequisicaoItem:=btnSalvarRequisicao.Tag,
                                                         iCodigoGrupoItem:=cboGrupoItemRequisicaoListaMaterial.SelectedValue,
                                                         iCodigoItem:=lCodigoItem,
                                                         dQuantidade:=txtQuantidadeCorte.Value,
                                                         dMedida1:=txtMedida1Corte.Value,
                                                         dMedida2:=txtMedida2Corte.Value,
                                                         dMedida3:=txtMedida3Corte.Value,
                                                         dMedida4:=txtMedida4Corte.Value,
                                                         dPeso:=txtPesoCorte.Value,
                                                         iCodigoUnidadeMedida:=IIf(cboUnidadeMedidaCorte.SelectedIndex = -1, -1, cboUnidadeMedidaCorte.SelectedValue),
                                                         sCodigoProduto:=sCodigoProduto,
                                                         sDescricao:=txtDescricaoCorte.Text.Trim,
                                                         iCodigoTipoItemRequisicao:=2,
                                                         bItemCompra:=False,
                                                         sDataNecessidade:=dtpDataNecessidade.Value,
                                                         sObservacao:=txtObservacao.Text,
                                                         sObservacaoInterna:=txtObservacaoInterna.Text,
                                                         sReferenciaEstrutura:=txtNumeroDesenho.Text.Trim,
                                                         lCodigoItemPai:=cboCodigoProdutoRequisicaoListaMaterial.SelectedValue)


            'Informa o usuário
            frmMain.Informacao(Mensagem.RegistroAlterado)


        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#End Region

End Class