Imports Janus.Windows.GridEX

Public Class frmFatEmissaoMDFeImportarNFe

#Region "::: VARIAVEIS :::"

    'Variável da Classe
    Private oClsUsrFatEmissaoMDFe As New clsUsrFatEmissaoMDFe
    Private lCodigoEmissaoCapa As Long
    Private bInserido As Boolean

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

    Public Property Inserido As Boolean
        Get
            Return binserido
        End Get
        Set(value As Boolean)
            binserido = value
        End Set
    End Property
   
#End Region

#Region "::: CONTROLES :::"


    Private Sub frm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

        'Configura Formulário
        Call ConfigurarFormulario()

    End Sub

    Private Sub frm_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        'Reposiciona UserControl
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


    Private Sub btnInserir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInserir.Click
        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Retorno para o user control
            bInserido = False

            If grdListagem.GetCheckedRows.Count = 0 Then

                'Informa ao usuário
                frmMain.Informacao(Mensagem.ValidacaoSelecionar)

                'Sai da funçao
                Exit Sub

            End If

            'Salva Dados do Registro
            Call ImportarNFe()

            'Retorno para o user control
            binserido = True

            'Fecha o formulario
            Me.Dispose()



        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
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

            'Adiciona KeyUP
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

         
            'carrega grid
            Call oClsUsrFatEmissaoMDFe.LoadGridNFeImportar(grdListagem, _
                                                           lcodigoemissaocapa)


            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    


    Private Sub ImportarNFe()

        Try


            For Each oRow In grdListagem.GetCheckedRows


                oClsUsrFatEmissaoMDFe.ImportarNFe(grdListagem, _
                                                  lCodigoEmissaoCapa)

            Next
        Catch ex As Exception
            Throw ex
        End Try

    End Sub


#End Region









End Class