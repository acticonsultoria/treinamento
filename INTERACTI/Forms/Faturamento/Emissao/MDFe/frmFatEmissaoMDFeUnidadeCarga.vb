Imports Janus.Windows.GridEX

Public Class frmFatEmissaoMDFeUnidadeCarga

#Region "::: VARIAVEIS :::"

    'Variável da Classe
    Private oClsFrmFatEmissaoMDFeUnidadeCarga As New clsFrmFatEmissaoMDFeUnidadeCarga
    Private lCodigoEmissaoCapa As Long
    Private sChaveAcesso As String
    Private iTipo As Integer

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

    Public Property ChaveAcesso() As String
        Get
            Return sChaveAcesso
        End Get
        Set(ByVal value As String)
            sChaveAcesso = value
        End Set
    End Property

    Public Property Tipo() As Integer
        Get
            Return iTipo
        End Get
        Set(ByVal value As Integer)
            iTipo = value
        End Set
    End Property

#End Region

#Region "::: CONTROLES :::"

#Region "::: DADOS GERAIS :::"

    Private Sub frmFatEmissaoMDFeUnidadeCarga_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode


            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub frmFatEmissaoMDFeUnidadeCarga_Resize(ByVal sender As Object, ByVal e As System.EventArgs)

        'Reposiciona UserControl
        Me.Top = (frmMain.picImage.Top + ((frmMain.picImage.Height - Me.Height) / 2))
        Me.Left = ((frmMain.picImage.Width - Me.Width) / 2)

    End Sub

    Private Sub frmFatEmissaoMDFeUnidadeCarga_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Configura Formulário
        Call ConfigurarFormulario()
    End Sub

#End Region

#Region "::: UNIDADE CARGA :::"

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click
        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Formulário
            If Validacao() = True Then

              'Salva Dados do Registro
                Call Salvar()

                'Fecha o Controle
                Me.Dispose()

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
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

            'Seta Ícone
            Me.Icon = frmMain.Icon

            'Adiciona KeyUP
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf frmFatEmissaoMDFeUnidadeCarga_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Carrega Combo
            Call LoadCombo(cboTipo, "sp_select_combo_static_tipo_unidade_carga_mdfe")

            'Seta Focu
            cboTipo.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

#End Region

#Region "::: UNIDADE CARGA :::"

    Private Function Validacao() As Boolean

        Try

            'Seta Retorno da Função
            Validacao = False

            'Verifica se foi Preenchido o Campo - Cliente
            If ValidaCampo(cboTipo, lblTipo) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Cliente
            If ValidaCampo(txtIdentificacao, lblIdentificacao, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Cliente
            If ValidaCampo(txtQuantidadeRateada, lblQuantidadeRateada, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Cliente
            If ValidaCampo(txtNumeroLacres, lblNumeroLacres, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Seta Retorno da Função
            Validacao = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub Salvar()
        Try
            oClsFrmFatEmissaoMDFeUnidadeCarga.ChaveAcesso = sChaveAcesso
            oClsFrmFatEmissaoMDFeUnidadeCarga.CodigoEmissaoCapa = lCodigoEmissaoCapa
            oClsFrmFatEmissaoMDFeUnidadeCarga.CodigoTipoUnidade = cboTipo.SelectedValue
            oClsFrmFatEmissaoMDFeUnidadeCarga.Identificacao = txtIdentificacao.Text
            oClsFrmFatEmissaoMDFeUnidadeCarga.Lacre = txtNumeroLacres.Value
            oClsFrmFatEmissaoMDFeUnidadeCarga.QuantidadeRateada = txtQuantidadeRateada.Value
            oClsFrmFatEmissaoMDFeUnidadeCarga.Tipo = iTipo

            If IsNumeric(btnSalvar.Tag) Then
                oClsFrmFatEmissaoMDFeUnidadeCarga.UpdateNotaFiscal(btnSalvar.Tag)
            Else
                oClsFrmFatEmissaoMDFeUnidadeCarga.Insert()
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub
#End Region

#End Region


    
    
End Class