Imports Janus.Windows.GridEX

Public Class frmEstRequisicaoCancelar

#Region "::: VARIAVEIS :::"

    'Variável da Classe
    Private oClsEstRequisicao As New clsUsrEstRequisicao

    Private sNumeroRequisicao As String
    Private sDataRequisicao As String
    Private sTipoRequisicao As String
    Private sNumeroDocumento As String
    Private sProduto As String
    Private dQuantidade As Double
    Private lCodigoRequisicao As Long
    Private iCodigoRequisicaoItem As Integer

#End Region

#Region "::: PROPERTIE :::"

    Public Property NumeroRequisicao() As String
        Get
            Return sNumeroRequisicao
        End Get
        Set(ByVal value As String)
            sNumeroRequisicao = value
        End Set
    End Property

    Public Property DataRequisicao() As String
        Get
            Return sDataRequisicao
        End Get
        Set(ByVal value As String)
            sDataRequisicao = value
        End Set
    End Property

    Public Property TipoRequisicao() As String
        Get
            Return sTipoRequisicao
        End Get
        Set(ByVal value As String)
            sTipoRequisicao = value
        End Set
    End Property

    Public Property NumeroDocumento() As String
        Get
            Return sNumeroDocumento
        End Get
        Set(ByVal value As String)
            sNumeroDocumento = value
        End Set
    End Property

    Public Property Produto() As String
        Get
            Return sProduto
        End Get
        Set(ByVal value As String)
            sProduto = value
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

    Public Property CodigoRequisicao() As Long
        Get
            Return lCodigoRequisicao
        End Get
        Set(ByVal value As Long)
            lCodigoRequisicao = value
        End Set
    End Property

    Public Property CodigoRequisicaoItem() As Integer
        Get
            Return iCodigoRequisicaoItem
        End Get
        Set(ByVal value As Integer)
            iCodigoRequisicaoItem = value
        End Set
    End Property

#End Region

#Region "::: CONTROLES :::"

#Region "::: DADOS GERAIS :::"

    Private Sub frmEstRequisicaoCancelar_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura Formulário
        Call ConfigurarFormulario()

    End Sub

    Private Sub frmEstRequisicaoCancelar_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        'Reposiciona Formulário
        Me.Top = (frmMain.picImage.Top + ((frmMain.picImage.Height - Me.Height) / 2))
        Me.Left = ((frmMain.picImage.Width - Me.Width) / 2)

    End Sub

#End Region

#Region "::: CANCELAR :::"

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Formulário
            If Validacao() = True Then

                'Cancela Requisição
                Call CancelarRequisicao()

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

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

#End Region

#End Region

#Region "::: FUNCTION / SUB :::"

#Region "::: DADOS GERAIS :::"

    Private Sub ConfigurarFormulario()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Carrega Dados do Item
            txtNumeroRequisicao.Text = sNumeroRequisicao
            txtDataRequisicao.Text = sDataRequisicao
            txtTipoRequisicao.Text = sTipoRequisicao
            txtNumeroDocumento.Text = sNumeroDocumento
            txtProduto.Text = sProduto
            txtQuantidade.Value = dQuantidade

            'Seta Focu
            txtQuantidadeCancelar.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

#End Region

#Region "::: CANCELAR :::"

    Private Sub CancelarRequisicao()

        Try

            'Verifica se o Usuário deseja Cancelar os Registros
            If MsgBox("Deseja Cancelar o(s) Registro(s) Selecionado(s)?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes Then

                'Seta Cursor do Mouse
                Cursor.Current = Cursors.WaitCursor

                'Reprova Requisição
                Call oClsEstRequisicao.Cancelar(lCodigoRequisicao, _
                                                iCodigoRequisicaoItem, _
                                                txtJustificativa.Text.Trim, _
                                                txtQuantidadeCancelar.Value)

                'Fecha o Formulário
                Me.Dispose()

            End If

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

            'Verifica se a Quantidade informada é Válida
            If ValidaCampo(txtQuantidadeCancelar, lblQuantidade, True) = False Then
                Exit Function
            ElseIf txtQuantidadeCancelar.Value > txtQuantidade.Value Then
                frmMain.errInfo.SetError(lblQuantidadeCancelar, "A Quantidade para Cancelar não pode ser maior que a Quantidade disponível.")
                txtQuantidadeCancelar.Focus()
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Justificativa
            If ValidaCampo(txtJustificativa, lblJustificativa, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Justificativa com menos de 15 caracteres
            If Len(txtJustificativa.Text.Trim) < 15 Then
                frmMain.errInfo.SetError(lblJustificativa, "A Justificativa do Cancelamento da(s) Requisição(ões) de Estoque deve possuir ao menos 15 Caracteres.")
                txtJustificativa.Focus()
                Exit Function
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