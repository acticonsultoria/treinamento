Imports Janus.Windows.GridEX

Public Class frmFinImportacaoExtratoCadastrarDocumento

#Region "::: VARIAVEIS :::"

    'Variável da Classe
    Private oGrid As GridEX
    Private iCodigoImportacaoExtrato As Integer
    Private oClsFinImportacaoExtratoCadastrarDocumento As New clsFrmFinImportacaoExtratoCadastrarDocumento
    Private bCadastro As Boolean = False

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

    Public Property CodigoImportacaoExtrato() As Integer
        Get
            Return iCodigoImportacaoExtrato
        End Get
        Set(ByVal value As Integer)
            iCodigoImportacaoExtrato = value
        End Set
    End Property

    Public Property Cadastro() As Boolean
        Get
            Return bCadastro
        End Get
        Set(ByVal value As Boolean)
            bCadastro = value
        End Set
    End Property

#End Region

#Region "::: CONTROLES :::"

    Private Sub btnProcurarFornecedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarFornecedor.Click

        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindParceiroNegocio"
            oForm.Titulo = Me.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar Parceiro de Negócio"

            'Seta Parametros
            iCodigoTipoParceiroNegocioFind = TipoParceiroNegocio.fornecedor
            oComboBoxFind = cboFornecedor

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            cboFornecedor.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarFornecedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarFornecedor.Click

        Try

            'Carrega o form de parceiro de negócio
            LoadUsrControlForm(Me, "usrCadParceiroNegocio")

            'Carrega Combo            
            LoadCombo(cboFornecedor, "sp_select_combo_cadastro_basico_fornecedor " & goUsuario.iEmpresa)

            'Seta Focu
            cboFornecedor.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarTipoDocumento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarTipoDocumento.Click

        Try

            'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadTipoDocumento")

            'Carrega Combo            
            LoadCombo(cboTipoDocumento, "sp_select_combo_cadastro_basico_tipo_documento " & goUsuario.iEmpresa)

            'Seta Focu
            cboTipoDocumento.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub frmFinImportacaoExtratoVinculo_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

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

    Private Sub btnFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Try

            'Carrega Dados da Grid
            Call LoadGrid()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click

        Try
            'Valida Dados do Formulário
            If Validacao() = True Then
                
                'Carrega Dados da Grid
                Call Cadastrar()

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: FUNCTION / SUB :::"

    Private Sub ConfigurarFormulario()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Formulário
            Me.Size = frmMain.tlpMain.Size : Me.Location = New Point(0, 23)

            'Seta Ícone
            Me.Icon = frmMain.Icon

            'Verifica se é Receita
            If txtTipo.Text = "RECEITA" Then
                Call LoadCombo(cboFornecedor, "sp_select_combo_cadastro_basico_cliente " & goUsuario.iEmpresa, False)
            Else
                Call LoadCombo(cboFornecedor, "sp_select_combo_cadastro_basico_fornecedor " & goUsuario.iEmpresa, False)
            End If

            Call LoadCombo(cboBancoContaTransferencia, "sp_select_combo_cadastro_basico_banco_conta " & goUsuario.iEmpresa)
            Call LoadCombo(cboTipoDocumento, "sp_select_combo_cadastro_basico_tipo_documento " & goUsuario.iEmpresa, False)
            Call LoadCombo(cboCentroCusto, "sp_select_combo_cadastro_basico_centro_custo " & goUsuario.iEmpresa)
            Call LoadCombo(cboContaContabil, "sp_select_combo_cadastro_basico_conta_contabil " & goUsuario.iEmpresa)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub LoadGrid()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'grdVinculo.DataSource = Nothing

            ''Carrega Controles
            'oClsFinImportacaoExtratoVinculo.LoadGrid(grdVinculo, _
            '                                         txtTipo.Text, _
            '                                         txtValor.Text, _
            '                                         txtValorCriterio.Text, _
            '                                         txtDataEmissao.Text, _
            '                                         txtDataCriterio.Text, _
            '                                         cboTituloFinanceiro.SelectedValue, _
            '                                         chkData.Checked, _
            '                                         chkValor.Checked)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Inserir()

        Try
            'oGrid.SetValue("documento_referencia", CStr(grdVinculo.GetValue("codigo_titulo_capa")) & "_" & CStr(grdVinculo.GetValue("numero_parcela")))

            'Me.Dispose()

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Cadastrar()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            Dim lCodigoTituloCapa As Long

            lCodigoTituloCapa = oClsFinImportacaoExtratoCadastrarDocumento.Cadastrar(cboTipoDocumento.SelectedValue, _
                                                                                      cboFornecedor.SelectedValue, _
                                                                                      txtTipo.Text, _
                                                                                      txtDescritivo.Text, _
                                                                                      txtNumeroDocumento.Text, _
                                                                                      txtDataEmissao.Text, _
                                                                                      txtValor.Text, _
                                                                                      IIf(cboCentroCusto.SelectedIndex = -1, -1, cboCentroCusto.SelectedValue), _
                                                                                      IIf(cboContaContabil.SelectedIndex = -1, "", cboContaContabil.SelectedValue))


            bCadastro = True
            oGrid.SetValue("documento_referencia", CStr(CStr(lCodigoTituloCapa) & "|1"))

            'Variaveis
            Dim sTexto As String = ""
            Dim sCodigoCentroCusto As String = ""

            'Seta Variaveis
            sTexto += IIf(sTexto = "", "", vbCrLf) + txtNumeroDocumento.Text + "|" + "1" + "-" + cboFornecedor.Text
            sCodigoCentroCusto = IIf(cboCentroCusto.SelectedIndex = -1, "", cboCentroCusto.SelectedValue)

            'Seta Colunas
            oGrid.SetValue("documento_referencia_texto", sTexto)
            oGrid.SetValue("centro_custo", IIf(sCodigoCentroCusto = "", DBNull.Value, sCodigoCentroCusto))

            'Verifica se foi seleciondo a Conta Bancaria
            If cboBancoContaTransferencia.SelectedIndex <> -1 Then
                oGrid.SetValue("codigo_banco_conta_transferencia", cboBancoContaTransferencia.SelectedValue)
                oGrid.SetValue("banco_conta_transferencia", cboBancoContaTransferencia.Text)
            Else
                oGrid.SetValue("codigo_banco_conta_transferencia", DBNull.Value)
                oGrid.SetValue("banco_conta_transferencia", DBNull.Value)
            End If

            Me.Dispose()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function Validacao() As Boolean

        Try

            'Seta Retorno da Função
            Validacao = False

            'Verifica se foi Preenchido o Campo - Número Documento
            If txtNumeroDocumento.Text.Trim = "-" Then
                'Verifica se o Usuário quer que o Sistema gere o Número do Documento Automaticamente
                'If MsgBox("Deseja que o Sistema gere o Número do Documento Automaticamente?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then
                txtNumeroDocumento.Text = oClsFinImportacaoExtratoCadastrarDocumento.GerarNumeroDocumento
                'End If
            End If

            'Verifica se foi Preenchido o Campo - Tipo Documento
            If ValidaCampo(cboTipoDocumento, lblTipoDocumento) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Tipo Documento
            If ValidaCampo(cboFornecedor, lblFornecedor) = False Then
                Exit Function
            End If

            'Seta Retorno da Função
            Validacao = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

    Private Sub btnProcurarCentroCusto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarCentroCusto.Click

        Try

            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindCentroGasto"
            oForm.Titulo = Me.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar Centro de Gasto"

            'Seta Parametros
            'iCodigoTipoParceiroNegocioFind = TipoParceiroNegocio.fornecedor
            oComboBoxFind = cboCentroCusto

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            cboCentroCusto.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub


    Private Sub cboCentroCusto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCentroCusto.SelectedIndexChanged
        Try
            If goDatabase.sInitialCatalog = "INTERACTI_ASCON_PRD" Then
                If cboCentroCusto.SelectedIndex = -1 Then Exit Sub

                Call LoadCombo(cboContaContabil, "sp_select_combo_cadastro_basico_conta_contabil_centro_gasto " & goUsuario.iEmpresa & ", " & cboCentroCusto.SelectedValue)
            End If

        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

End Class