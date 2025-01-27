Imports Janus.Windows.GridEX

Public Class frmCmpCotacaoItemAdicionar

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsCmpCotacao As New clsUsrCmpCotacao
    Private sNumeroRequisicao As String
    Private sDataNecessidade As String
    Private dQuantidade As Double
    Private sUnidadeMedida As String
    Private sItem As String
    Private lCodigoRequisicao As Long
    Private iCodigoRequisicaoItem As Integer

#End Region

#Region "::: PROPERTIE :::"

    Public WriteOnly Property NumeroRequisicao() As String
        Set(ByVal value As String)
            sNumeroRequisicao = value
        End Set
    End Property

    Public WriteOnly Property DataNecessidade() As String
        Set(ByVal value As String)
            sDataNecessidade = value
        End Set
    End Property

    Public WriteOnly Property Quantidade() As Double
        Set(ByVal value As Double)
            dQuantidade = value
        End Set
    End Property

    Public WriteOnly Property UnidadeMedida() As String
        Set(ByVal value As String)
            sUnidadeMedida = value
        End Set
    End Property

    Public WriteOnly Property Item() As String
        Set(ByVal value As String)
            sItem = value
        End Set
    End Property

    Public WriteOnly Property CodigoRequisicao() As Long
        Set(ByVal value As Long)
            lCodigoRequisicao = value
        End Set
    End Property

    Public WriteOnly Property CodigoRequisicaoItem() As Integer
        Set(ByVal value As Integer)
            iCodigoRequisicaoItem = value
        End Set
    End Property

#End Region

#Region "::: CONTROLES :::"

    Private Sub frmCmpCotacaoItemAdicionar_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura Formulário
        Call ConfigurarFormulario()

    End Sub

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Formulário
            If Validacao() = True Then

                'Salva Dados do Registro
                Call Salvar()
                'Fecha Formulário
                Me.Dispose()

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click

        'Fecha o Controle
        Me.Dispose()

    End Sub

    Private Sub cboNumeroCotacao_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboNumeroCotacao.SelectedIndexChanged

        Try

            'Verifica se foi selecionado algum Registro
            If cboNumeroCotacao.SelectedIndex = -1 Then
                'Limpa Controles
                txtDataCotacao.Text = ""
                txtUsuarioCotacao.Text = ""
            Else
                'Carrega Dados da Cotação
                oClsCmpCotacao.LoadDadosCotacao(cboNumeroCotacao.SelectedValue, _
                                                txtDataCotacao, _
                                                txtUsuarioCotacao)
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

            'Verifica Direito
            btnSalvar.Enabled = VerificaDireito(Formulario.ComprasCotacao, gcInsert)

            'Carrega Combo
            Call LoadCombo(cboNumeroCotacao, "sp_select_combo_compras_cotacao_status " & goUsuario.iEmpresa & "," & CInt(StatusComprasCotacao.Cotando).ToString, False)

            'Carrega Controles            
            txtNumeroRequisicao.Text = sNumeroRequisicao
            txtDataNecessidade.Text = sDataNecessidade
            txtQuantidade.Value = dQuantidade
            txtUnidadeMedida.Text = sUnidadeMedida
            txtItem.Text = sItem

            'Seta Focu
            cboNumeroCotacao.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub Salvar()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Cancela Item da Cotação
            oClsCmpCotacao.InsertCotacaoItem(cboNumeroCotacao.SelectedValue, _
                                             lCodigoRequisicao, _
                                             iCodigoRequisicaoItem)

            'Informa o Usuário sobre o Sucesso da Operação            
            frmMain.Informacao(Mensagem.OperacaoRealizadaSucesso)

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

            'Verifica se foi Selecionado o Campo - Nº Cotação
            If ValidaCampo(cboNumeroCotacao, lblNumeroCotacao) = False Then
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