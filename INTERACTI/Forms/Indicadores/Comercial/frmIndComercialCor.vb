Imports Janus.Windows.GridEX

Public Class frmIndComercialCor

#Region "::: VARIAVEIS :::"

    Private oClsIndFinanceiro As New clsUsrIndFinanceiro
    Private iSeries As Integer
    Private iCodigo As Integer
    Private sTipoGrafico As String
    Private cCor As Color

#End Region

    Public Property TipoGrafico() As String
        Get
            Return sTipoGrafico
        End Get
        Set(ByVal value As String)
            sTipoGrafico = value
        End Set
    End Property

    Public Property Series() As Integer
        Get
            Return iSeries
        End Get
        Set(ByVal value As Integer)
            iSeries = value
        End Set
    End Property

    Public Property Codigo() As Integer
        Get
            Return iCodigo
        End Get
        Set(ByVal value As Integer)
            iCodigo = value
        End Set
    End Property

    Public Property Cor() As Color
        Get
            Return cCor
        End Get
        Set(ByVal value As Color)
            cCor = value
        End Set
    End Property

#Region "::: CONTROLES :::"
    Private Sub picCor1_MoreColorsButtonClick(sender As Object, e As EventArgs) Handles picCor.MoreColorsButtonClick

        Try

            Dim oColorDialog As New ColorDialog()

            oColorDialog.AllowFullOpen = True
            oColorDialog.ShowHelp = True
            oColorDialog.Color = picCor.SelectedColor

            If oColorDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                picCor.SelectedColor = oColorDialog.Color
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub
    Private Sub frmVenPedidoCancelar_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura Formulário
        Call ConfigurarFormulario()

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


    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click

        Try

            'Valida Dados do Formulário
            If Validacao() = True Then

                'Salvar
                Salvar()

            End If

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

            'Adiciona KeyUP
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            cboTipoGrafico.Items.Clear()

            cboTipoGrafico.Items.Add("COLUNA", "COLUMN")
            cboTipoGrafico.Items.Add("LINHA", "LINE")
            cboTipoGrafico.SelectedValue = sTipoGrafico
            picCor.SelectedColor = cCor

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub Salvar()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            Cor = picCor.SelectedColor
            sTipoGrafico = cboTipoGrafico.SelectedValue


            Dim sCor As String = ""

            sCor &= CStr(cCor.R)
            sCor &= "," & CStr(cCor.G)
            sCor &= "," & CStr(cCor.B)

            oClsIndFinanceiro.AtualizarCores(Codigo, _
                                             Series, _
                                             sCor, _
                                             cboTipoGrafico.SelectedValue)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

            'Fecha o Formulário
            Me.Dispose()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Function Validacao() As Boolean

        Try

            'Seta Retorno da Função
            Validacao = False

            If IsNothing(picCor.SelectedColor) Then
                frmMain.errInfo.SetError(lblCorSerie, "Selecione uma cor.")
                Exit Function
            End If

            If ValidaCampo(cboTipoGrafico, lblTipoFiltro) = False Then
                Exit Function
            End If

            'Seta Retorno da Função
            Validacao = True

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Function

#End Region



End Class