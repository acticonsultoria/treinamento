Imports System.Drawing.Printing

Public Class frmIntEscolherImpressora

#Region "::: VARIAVEIS :::"

    Private sImpressora As String
#End Region

#Region "::: PROPERTIES :::"


    Public Property Impressora() As String
        Get
            Return sImpressora
        End Get
        Set(ByVal value As String)
            sImpressora = value
        End Set
    End Property

#End Region

#Region "::: CONTROLES :::"

    Private Sub frmLogin_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'Configura Formulário
        Call ConfigureForm()

    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click
        'Fechando
        Me.Visible = False
    End Sub
    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        Try

            If ValidaCampo(cboImpressora, lblImpressora) = False Then
                Exit Sub
            End If


            'Passagem de parâmetro
            sImpressora = cboImpressora.Text

            'Fechando
            Me.Visible = False

        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub
#End Region

#Region "::: FUNCTION / SUB :::"

    Private Sub ConfigureForm()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            With cboImpressora

                'Varrendo todas impressoras
                For Each sNomeImpressora As String In PrinterSettings.InstalledPrinters
                    cboImpressora.Items.Add(sNomeImpressora)
                Next

            End With


            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region


End Class
