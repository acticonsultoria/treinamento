Imports System.IO
Imports Microsoft.Win32

Public Class frmLiberacao

#Region "::: VARIAVEIS :::"

    'Variaveis do Módulo
    Private oClsLiberacao As New clsFrmLiberacao
    Private iCodigoUsuario As Integer
    Private iCodigoFormulario As Formulario
    Private sDireito As String

#End Region

#Region "::: PROPERTIE :::"

    Public ReadOnly Property CodigoUsuario() As Integer
        Get
            Return iCodigoUsuario
        End Get
    End Property

    Public WriteOnly Property CodigoFormulario() As Formulario
        Set(ByVal value As Formulario)
            iCodigoFormulario = value
        End Set
    End Property

    Public WriteOnly Property Direito() As String
        Set(ByVal value As String)
            sDireito = value
        End Set
    End Property

#End Region

#Region "::: CONTROLES :::"

    Private Sub frmLiberacao_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        'Verifica se foi pressionado a tecla enter
        If e.KeyCode = Windows.Forms.Keys.Enter Then
            'Executa Clique do Botão - Logar
            Call btnLiberar_Click(btnLiberar, System.EventArgs.Empty)
        End If

    End Sub

    Private Sub frmLiberacao_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura Formulário
        Call ConfigureFormulario()

    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click

        Try

            If goUsuario.sUsuario = "" Then
                End
            Else
                Dispose()
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnLiberar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLiberar.Click

        Try

            'Valida Dados do Formulário
            If Validacao() = True Then

                'Fecha Formulário
                Me.Dispose()                

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

#End Region

#Region "::: FUNCTION / SUB :::"

    Private Sub ConfigureFormulario()

        Try

            'Seta Ícone
            Me.Icon = frmMain.Icon

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Label
            Me.Text = gAplicacao & " Versão: " & Application.ProductVersion.ToString
            Label1.Text = goUsuario.sEmpresa
            Dim oFileInfo As FileInfo = New FileInfo(ApplicationPath() & My.Application.Info.AssemblyName.ToString & ".exe")
            lblSistema.Text = gAplicacao & " - Versão: " & Application.ProductVersion.ToString & " - Última Atualização: " & Format(oFileInfo.CreationTime, "dd/MM/yyyy")

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

            'Verifica se foi Preenchido o Campo - Usuário
            If ValidaCampo(txtUsuario, lblUsuario, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Senha
            If ValidaCampo(txtSenha, lblSenha, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Verifica se o Usuário é Válido
            iCodigoUsuario = oClsLiberacao.ValidaUsuario(txtUsuario.Text.Trim, txtSenha.Text.Trim, iCodigoFormulario, sDireito)

            If iCodigoUsuario = -1 Then
                'Informa o Usuário que a Senha está errada
                frmMain.errInfo.SetError(lblUsuario, "Usuário ou Senha informados são inválidos, ou não tem direito para Liberar.")
                txtUsuario.Focus()
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
