Imports System.Threading
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls
Imports Janus.Windows.EditControls
Imports Microsoft.Office.Interop

Public Class frmMsgBox

#Region "::: VARIAVES :::"

    Private sMensagem As String
    Private sTitulo As String
    Private sMensagemButton As String
    Private sUserControl As String
    Private lCodigo As Long


#End Region

#Region "::: PROPERTY :::"

    Public Property Mensagem() As String
        Get
            Return sMensagem
        End Get
        Set(ByVal value As String)
            sMensagem = value
        End Set
    End Property

    Public Property Titulo() As String
        Get
            Return sTitulo
        End Get
        Set(ByVal value As String)
            sTitulo = value
        End Set
    End Property

    Public Property MensagemButton() As String
        Get
            Return sMensagemButton
        End Get
        Set(ByVal value As String)
            sMensagemButton = value
        End Set
    End Property

    Public Property UserControl() As String
        Get
            Return sUserControl
        End Get
        Set(ByVal value As String)
            sUserControl = value
        End Set
    End Property

    Public Property Codigo() As String
        Get
            Return lCodigo
        End Get
        Set(ByVal value As String)
            lCodigo = value
        End Set
    End Property

#End Region

#Region "::: CONTROLES :::"

    Private Sub frm_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        ConfigurarForm()

    End Sub

#End Region

#Region "::: FUNCTION / SUB :::"

    Private Sub ConfigurarForm()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            FormBorderStyle = Windows.Forms.FormBorderStyle.FixedDialog
            StartPosition = FormStartPosition.CenterScreen
            MaximizeBox = False
            MinimizeBox = False
            ShowInTaskbar = False

            lblMensagem.Text = sMensagem
            Me.Text = sTitulo

            btnAcao.Size = New Size(Len(sMensagemButton) * 6, 23)
            btnAcao.Location = New Point(btnSair.Location.X - 6 - Len(sMensagemButton) * 6, 8)
            btnAcao.Text = sMensagemButton

            'Seta Ícone
            Me.Icon = frmMain.Icon

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

#End Region

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click

        Try

            Me.Dispose()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnAcao_Click(sender As Object, e As EventArgs) Handles btnAcao.Click

        Try

            lCodigoMsgBox = lCodigo

            LoadUsrControlForm(Me, sUserControl)

            Me.Dispose()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

End Class