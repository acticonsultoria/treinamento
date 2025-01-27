Imports Janus.Windows.GridEX

Public Class frmFatEntradaNFFatura

#Region "::: VARIAVEIS :::"

    'Variável da Classe
    Private oClsFatEntradaNF As New clsUsrFatEntradaNF
    Private sNotaFiscal As String
    Private sSerie As String
    Private sDataEmissao As String
    Private sDataEntrada As String
    Private sEmitente As String
    Private lCodigoEntradaCapa As Long

#End Region

#Region "::: PROPERTIE :::"

    Public WriteOnly Property NotaFiscal() As String
        Set(ByVal value As String)
            sNotaFiscal = value
        End Set
    End Property

    Public WriteOnly Property Serie() As String
        Set(ByVal value As String)
            sSerie = value
        End Set
    End Property

    Public WriteOnly Property DataEmissao() As String
        Set(ByVal value As String)
            sDataEmissao = value
        End Set
    End Property

    Public WriteOnly Property DataEntrada() As String
        Set(ByVal value As String)
            sDataEntrada = value
        End Set
    End Property

    Public WriteOnly Property Emitente() As String
        Set(ByVal value As String)
            sEmitente = value
        End Set
    End Property

    Public WriteOnly Property CodigoEntradaCapa() As Long
        Set(ByVal value As Long)
            lCodigoEntradaCapa = value
        End Set
    End Property

#End Region

#Region "::: CONTROLES :::"

    Private Sub frmFatEntradaNFCancelar_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Escape : Me.Dispose()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub frmFatEntradaNFCancelar_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

        'Configura UserControl
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

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click

        Try

            'Valida Dados do Formulário
            If Validacao() = True Then

                'Cancela Nota Fiscal
                Call InserirNotaFiscalFatura()

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

#End Region

#Region "::: FUNCTION / SUB :::"

#Region "::: DADOS GERAIS :::"

    Private Sub ConfigurarFormulario()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Ícone
            Me.Icon = frmMain.Icon

            'Adiciona KeyUP
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf frmFatEntradaNFCancelar_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Seta Tamanho / Posição do Formulário
            'Me.Size = frmMain.tlpMain.Size : Me.Location = New Point(0, 23)
            Call LoadCombo(cboTipo, "sp_select_combo_static_nf_fatura")
            Call LoadCombo(cboFornecedor, "sp_select_combo_cadastro_basico_fornecedor " & goUsuario.iEmpresa)

            'Carrega Dados da Nota Fiscal            
            txtNotaFiscal.Text = ""
            txtSerie.Text = ""
            dtpDataEmissaoNF.Value = Now.Date
            cboFornecedor.SelectedIndex = -1
            cboTipo.SelectedIndex = -1
            txtValorTotal.Value = 0
            

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

#End Region

#Region "::: NOTA FISCAL :::"

    Private Sub InserirNotaFiscalFatura()

        Try


            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Atualiza a Nota Fiscal
            Call oClsFatEntradaNF.UpdateNFFatura(lCodigoEntradaCapa, dtpDataEmissaoNF.Value, txtSerie.Text, txtNotaFiscal.Text, cboTipo.SelectedValue)
            'Insere o Destinatário
            Call oClsFatEntradaNF.InsertDestinatarioFatura(lCodigoEntradaCapa)
            'Insere o Emitente
            Call oClsFatEntradaNF.InsertEmitenteFatura(lCodigoEntradaCapa, cboFornecedor.SelectedValue)
            'Insere Transporte
            Call oClsFatEntradaNF.InsertTransporteFatura(lCodigoEntradaCapa)
            'Insere o Item
            oClsFatEntradaNF.InsertProdutoFatura(lCodigoEntradaCapa, txtValorTotal.Value, cboTipo.SelectedValue)
            'Insere ICMS
            Call oClsFatEntradaNF.InsertImpostoICMSFatura(lCodigoEntradaCapa, cboTipo.SelectedValue)
            'Insere IPI
            Call oClsFatEntradaNF.InsertImpostoIPIFatura(lCodigoEntradaCapa, cboTipo.SelectedValue)
            'Insere PIS
            Call oClsFatEntradaNF.InsertImpostoPISFatura(lCodigoEntradaCapa, cboTipo.SelectedValue)
            'Insere o COFINS
            Call oClsFatEntradaNF.InsertImpostoCOFINSFatura(lCodigoEntradaCapa, cboTipo.SelectedValue)
            ''Integração
            Call Integracao()


            'Fecha o Formulário
            Me.Dispose()



            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Function Validacao() As Boolean

        Try

            'Seta Retorno da Função
            Validacao = False

            'Verifica se foi Preenchido o Campo - Justificativa
            If ValidaCampo(txtNotaFiscal, lblNotaFiscal, TipoCampo.texto) = False Then
                Exit Function
            End If

            If ValidaCampo(txtSerie, lblSerie, TipoCampo.texto) = False Then
                Exit Function
            End If

            If ValidaCampo(cboFornecedor, lblFornecedor) = False Then
                Exit Function
            End If

            If ValidaCampo(txtValorTotal, lblValorTotal, TipoCampo.numero) = False Then
                Exit Function
            End If

            If ValidaCampo(cboTipo, lblTipo) = False Then
                Exit Function
            End If
            'Seta Retorno da Função
            Validacao = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#Region " ::: INTEGRAÇÃO ::: "

    Private Sub Integracao()

        Try

            'Váriavel - Integração
            Dim oClsIntegracao As New clsIntegracao

            'Integração - Compras
            oClsIntegracao.IntegracaoNFEntradaCompras(lCodigoEntradaCapa)
            'Integração - Estoque
            oClsIntegracao.IntegracaoNFEntradaEstoque(lCodigoEntradaCapa)
            'Integração - Financeiro
            oClsIntegracao.IntegracaoNFEntradaFinanceiro(lCodigoEntradaCapa)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#End Region

    Private Sub btnProcurarFornecedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarFornecedor.Click
        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindParceiroNegocio"
            oForm.Titulo = Me.Parent.Text
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
End Class