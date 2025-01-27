Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX.EditControls
Imports Janus.Windows.GridEX

Public Class frmImpECF

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsCadNCM As New clsUsrCadNCM
    Private sNCM As String
    Private iCodigoNCM As Integer
    Private sAliquotaICMS As String

#End Region

#Region "::: PROPERTIE :::"

    Public Property CodigoNCM() As Integer
        Get
            Return iCodigoNCM
        End Get
        Set(ByVal value As Integer)
            iCodigoNCM = value
        End Set
    End Property

    Public Property NCM() As String
        Get
            Return sNCM
        End Get
        Set(ByVal value As String)
            sNCM = value
        End Set
    End Property

    Public Property AliquotaICMS() As String
        Get
            Return sAliquotaICMS
        End Get
        Set(ByVal value As String)
            sAliquotaICMS = value
        End Set
    End Property

#End Region

#Region "::: CONTROLES :::"

    Private Sub frmImpECF_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarFormulario()

    End Sub

    Private Sub frmImpECF_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        'Redimensiona UserControl
        Me.Top = (frmMain.picImage.Top + ((frmMain.picImage.Height - Me.Height) / 2))
        Me.Left = ((frmMain.picImage.Width - Me.Width) / 2)

    End Sub

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Formulário
            If Validacao() = True Then

                'Salva Dados do Registro
                Call Salvar()

                'Fecha o Formulário
                Me.Dispose()

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

#Region "::: FUNCTION / SUB :::"

    Public Sub ConfigurarFormulario()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Ícone
            Me.Icon = frmMain.Icon

            'Verifica Direito
            btnSair.Enabled = VerificaDireito(Formulario.CadastroBasicoNCM, gcUpdate)

            'Carrega ComboBox
            Call LoadCombo(cboAliquotaICMS, "sp_select_combo_static_ecf_aliquota_icms")

            'Seta Controles
            txtNCM.Text = sNCM
            If sAliquotaICMS <> "" Then cboAliquotaICMS.SelectedValue = sAliquotaICMS

            'Seta Focu
            cboAliquotaICMS.Focus()

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

            'Seta Parametros
            oClsCadNCM.UpdateAliquotaECF(iCodigoNCM, _
                                         cboAliquotaICMS.SelectedValue)

            'Informa o Usuário sobre o Suceusso da Operação
            frmMain.Informacao(Mensagem.RegistroSalvo)
            
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

            'Verifica se foi Selecionado o Campo - Alíquota ICMS
            If ValidaCampo(cboAliquotaICMS, lblAliquotaICMS) = False Then
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
