Imports Janus.Windows.EditControls
Imports System.Net
Imports System.Text

Public Class frmActMaps

#Region "::: VARIAVEIS :::"

    'Variável da Classe
    Private sEnderecoDestino As String
    Private sCEPDestino As String
    Private sMunicipioDestino As String

#End Region

#Region "::: PROPERTIE :::"

    Public WriteOnly Property EnderecoDestino() As String
        Set(ByVal value As String)
            sEnderecoDestino = value
        End Set
    End Property

    Public WriteOnly Property CepDestino() As String
        Set(ByVal value As String)
            sCEPDestino = value
        End Set
    End Property

    Public WriteOnly Property MunicipioDestino() As String
        Set(ByVal value As String)
            sMunicipioDestino = value
        End Set
    End Property

#End Region

#Region "::: CONTROLES :::"

    Private Sub frmActMaps_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura Formulário
        Call ConfigurarFormulario()

    End Sub

    Private Sub frmActMaps_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        Me.Top = (frmMain.picImage.Top + ((frmMain.picImage.Height - Me.Height) / 2))
        Me.Left = ((frmMain.picImage.Width - Me.Width) / 2)

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

    Private Sub btnIr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIr.Click

        Try

            'Mapa
            Call Mapa(True)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click

        Try

            'Imprimir
            Call Imprimir()

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

            'Carrega Dados do Emitente
            Call LoadDadosEmitente()

            'Carrega Controles
            txtEnderecoPadrao.Text = goEmitente.sLogradouro + ", " & goEmitente.sNumero
            txtCEPPadrao.Text = goEmitente.sCEP
            txtMunicipioPadrao.Text = goEmitente.sMunicipio
            txtEnderecoDestino.Text = sEnderecoDestino
            txtCEPDestino.Text = sCEPDestino
            txtMunicipioDestino.Text = sMunicipioDestino

            'Carrega Mapa
            Call Mapa(False)

            'Seta Focu
            btnIr.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub Imprimir()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            webMain.ShowPrintPreviewDialog()

            If webMain.Document.Title = Nothing Then
                webMain.Document.Title = String.Format("{0} ,{1} ,{1}", txtEnderecoDestino.Text.Trim, txtCEPDestino.Text.Trim)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Mapa(ByVal bRota As Boolean)

        Try

            'Seta Cursor do Mouse
            TopLevelControl.Cursor = Cursors.WaitCursor

            'Verifica se a Internet está disponível
            'If IsInternetConnAvailable() = True Then

            'Seta Controle
            btnImprimir.Enabled = True
            btnIr.Enabled = True

            Dim sURL As New StringBuilder()

            Try

                webMain.Refresh(WebBrowserRefreshOption.Completely)

                If bRota = False Then

                    'Carrega Váriavel - URL
                    sURL.Append("http://maps.google.com/maps?q=")
                    sURL.Append(txtEnderecoDestino.Text.Trim & ", ")
                    sURL.Append(txtCEPDestino.Text.Trim & " ")
                    sURL.Append(txtMunicipioDestino.Text.Trim & ", ")
                    sURL.Append("Brasil")
                    sURL.Append("&output=embed&z=60")

                Else

                    
                    'Carrega Váriavel - URL
                    sURL.Append("http://maps.google.com/maps?q=from:+")
                    sURL.Append(txtEnderecoPadrao.Text.Trim & "%AD+")
                    sURL.Append(txtCEPPadrao.Text.Trim & "%AD+")
                    sURL.Append(txtMunicipioPadrao.Text.Trim & "%AD+")
                    sURL.Append("Brasil+")
                    sURL.Append("to:" & txtEnderecoDestino.Text.Trim & "%AD+")
                    sURL.Append(txtCEPDestino.Text.Trim & "%AD+")
                    sURL.Append(txtMunicipioDestino.Text.Trim & "%AD+")
                    sURL.Append("Brasil")
                    sURL.Append("&saddr=")
                    sURL.Append(txtEnderecoPadrao.Text.Trim & "%AD+")
                    sURL.Append(txtCEPPadrao.Text.Trim & "%AD+")
                    sURL.Append(txtMunicipioPadrao.Text.Trim & "%AD+")
                    sURL.Append("Brasil+")
                    sURL.Append("&daddr=" & txtEnderecoDestino.Text.Trim & "%AD+")
                    sURL.Append(txtCEPDestino.Text.Trim & "%AD+")
                    sURL.Append(txtMunicipioDestino.Text.Trim & "%AD+")
                    sURL.Append("Brasil")
                    sURL.Append("&hl=pt-BR&ie=UTF8&output=embed&z=60")

                End If

                webMain.Navigate(sURL.ToString())

            Catch ex As Exception
                MessageBox.Show(ex.Message.ToString)
            End Try

            'End If

        Catch ex As Exception
            Throw ex
        Finally
            TopLevelControl.Cursor = Cursors.Default
        End Try

    End Sub

#End Region

End Class