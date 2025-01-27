Imports Dundas.Charting.WinControl

Public Class usrChart

#Region "::: VÁRIAVEIS :::"

    'Classe
    Private oClsChart As New clsUsrChart

    'Váriaveis de Propriedade do Gráfico
    Private sQuery As String
    Private sTitle As String
    Private oGrafico As Grafico

#End Region

#Region "::: PROPERTIE :::"

    Public Property Query() As String
        Get
            Return sQuery
        End Get
        Set(ByVal value As String)
            sQuery = value
        End Set
    End Property

    Public Property Title() As String
        Get
            Return sTitle
        End Get
        Set(ByVal value As String)
            sTitle = value
        End Set
    End Property

    Public Property Grafico() As Grafico
        Get
            Return oGrafico
        End Get
        Set(ByVal value As Grafico)
            oGrafico = value
        End Set
    End Property

#End Region

#Region "::: CONTROLES :::"

    Private Sub usrChart_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Escape : Call btnSair_Click(btnSair, System.EventArgs.Empty)

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub usrChart_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

    Private Sub usrChart_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        'Reposiciona UserControl
        Me.Top = (frmMain.picImage.Top + ((frmMain.picImage.Height - Me.Height) / 2))
        Me.Left = ((frmMain.picImage.Width - Me.Width) / 2)

    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click

        'Deleta Aba
        If TypeOf Me.Parent Is Form Then Me.Parent.Dispose() Else If TypeOf Me.Parent Is Panel Then Me.Parent.Controls.Remove(Me) Else frmMain.tabMain.TabPages.Remove(Me.Parent)
        'Fecha o Controle
        Me.Dispose()

    End Sub

#End Region

#Region "::: FUNCTION / SUB :::"

    Private Sub ConfigurarUserControl()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Adiciona KeyUP
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrChart_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Carrega Gráfico
            Call oClsChart.LoadGrafico(chrMain, sQuery, oGrafico)

            'Adiciona Título
            chrMain.Titles.Add(sTitle)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

End Class
