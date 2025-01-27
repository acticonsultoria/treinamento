Imports Janus.Windows.GridEX

Public Class frmEmailContato

#Region "::: VARIAVEIS :::"

    'Variável da Classe
    Private lCodigoParceiroNegocio As Long
    Private oClsEmailContato As New clsFrmEmailContato
    Private oFormulario As frmEmail

#End Region

#Region "::: PROPERTIE :::"

    Public Property CodigoParceiroNegocio() As Long
        Get
            Return lCodigoParceiroNegocio
        End Get
        Set(ByVal value As Long)
            lCodigoParceiroNegocio = value
        End Set
    End Property

    Public Property Formulario() As frmEmail
        Get
            Return oFormulario
        End Get
        Set(ByVal value As frmEmail)
            oFormulario = value
        End Set
    End Property

#End Region

#Region "::: CONTROLES :::"

    Private Sub frmEmailContato_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura Formulário
        Call ConfigurarForm()

    End Sub

    Private Sub frmEmailContato_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        'Redimensiona Formulário
        Me.Top = (frmMain.picImage.Top + ((frmMain.picImage.Height - Me.Height) / 2))
        Me.Left = ((frmMain.picImage.Width - Me.Width) / 2)

    End Sub

    Private Sub btnCC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCC.Click

        Try

            'Verifica se foi selecionado um ou mais registros
            If VerificaSelecaoRow(grdContato) = True Then

                'Váriaveis Locais
                Dim i As Integer

                For i = 0 To UBound(gSelecaoRow)
                    txtCC.Text = txtCC.Text & IIf(txtCC.Text = "", "", "; ") & gSelecaoRow(i).Cells("email").Value
                Next i

            Else
                'Informa o Usuário da Necessidade de Selecionar um ou mai Registro
                frmMain.Informacao(Mensagem.ValidacaoSelecionar)
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnBcc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBcc.Click

        Try

            'Verifica se foi selecionado um ou mais registros
            If VerificaSelecaoRow(grdContato) = True Then

                'Váriaveis Locais
                Dim i As Integer

                For i = 0 To UBound(gSelecaoRow)
                    txtBcc.Text = txtBcc.Text & IIf(txtCC.Text = "", "", "; ") & gSelecaoRow(i).Cells("email").Value
                Next i

            Else
                'Informa o Usuário da Necessidade de Selecionar um ou mai Registro
                frmMain.Informacao(Mensagem.ValidacaoSelecionar)
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnPara_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPara.Click

        Try

            'Verifica se foi selecionado um ou mais registros
            If VerificaSelecaoRow(grdContato) = True Then

                'Váriaveis Locais
                Dim i As Integer

                For i = 0 To UBound(gSelecaoRow)
                    txtPara.Text = txtPara.Text & IIf(txtPara.Text = "", "", "; ") & gSelecaoRow(i).Cells("email").Value
                Next i

            Else
                'Informa o Usuário da Necessidade de Selecionar um ou mai Registro
                frmMain.Informacao(Mensagem.ValidacaoSelecionar)
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnConfirmar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirmar.Click

        Try

            'Seta Dados
            If txtPara.Text.Trim <> "" Then oFormulario.txtPara.Text &= IIf(oFormulario.txtPara.Text = "", "", "; ") & txtPara.Text
            If txtCC.Text.Trim <> "" Then oFormulario.txtCC.Text &= IIf(oFormulario.txtCC.Text = "", "", "; ") & txtCC.Text
            If txtBcc.Text.Trim <> "" Then oFormulario.txtBcc.Text &= IIf(oFormulario.txtBcc.Text = "", "", "; ") & txtBcc.Text

            'Fecha o Formulário
            Me.Dispose()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click

        'Fecha o Formulário
        Me.Dispose()

    End Sub

#End Region

#Region "::: FUNCTION / SUB :::"

    Private Sub ConfigurarForm()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Ícone
            Me.Icon = frmMain.Icon

            'Carrega Lista de Contatos
            oClsEmailContato.LoadContato(grdContato, _
                                         lCodigoParceiroNegocio)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

#End Region

End Class