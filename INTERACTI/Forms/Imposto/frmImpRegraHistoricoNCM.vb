Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX.EditControls

Public Class frmImpRegraHistoricoNCM

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsCadNCM As New clsUsrCadNCM
    Private iCodigoNCM As Integer
    Private sCodigoNCM As String
    Private cboCFOP As UIComboBox
    Private cboCST As UIComboBox
    Private txtAliquotaICMS As NumericEditBox

#End Region

#Region "::: PROPERTIE :::"

    Public WriteOnly Property CodigoNCM() As Integer
        Set(ByVal value As Integer)
            iCodigoNCM = value
        End Set
    End Property

    Public WriteOnly Property NCM() As String
        Set(ByVal value As String)
            sCodigoNCM = value
        End Set
    End Property

    Public WriteOnly Property ComboBoxCFOP() As UIComboBox
        Set(ByVal value As UIComboBox)
            cboCFOP = value
        End Set
    End Property

    Public WriteOnly Property ComboBoxCST() As UIComboBox
        Set(ByVal value As UIComboBox)
            cboCST = value
        End Set
    End Property

    Public WriteOnly Property NumericEditBoxAliquotaICMS() As NumericEditBox
        Set(ByVal value As NumericEditBox)
            txtAliquotaICMS = value
        End Set
    End Property

#End Region

#Region "::: CONTROLES :::"

    Private Sub frmImpRegraHistoricoNCM_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown, _
                                                                                                                           grdRegra.KeyUp


        Try

            Select Case e.KeyCode

                Case Keys.Enter
                    If Not grdRegra.CurrentRow Is Nothing Then
                        cboCFOP.Text = grdRegra.CurrentRow.Cells("cfop").Value
                        cboCST.SelectedValue = grdRegra.CurrentRow.Cells("cst_icms").Value
                        txtAliquotaICMS.Value = grdRegra.CurrentRow.Cells("aliquota_icms").Value
                        Me.Dispose()
                    End If

                Case Keys.Escape
                    'Deleta Aba
                    If TypeOf Me.Parent Is Form Then Me.Parent.Dispose() Else If TypeOf Me.Parent Is Panel Then Me.Parent.Controls.Remove(Me) Else frmMain.tabMain.TabPages.Remove(Me.Parent)
                    'Fecha o Controle
                    Me.Dispose()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub frmImpRegraHistoricoNCM_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura Formulário
        Call ConfigurarFormulario()

    End Sub

    Private Sub grdListagem_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdRegra.RowDoubleClick

        Try

            'Carrega Controles
            cboCFOP.Text = grdRegra.CurrentRow.Cells("cfop").Value
            cboCST.SelectedValue = grdRegra.CurrentRow.Cells("cst_icms").Value
            txtAliquotaICMS.Value = grdRegra.CurrentRow.Cells("aliquota_icms").Value
            Me.Dispose()

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
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf frmImpRegraHistoricoNCM_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Seta Tamanho / Posição do Formulário
            Me.Size = frmMain.tlpMain.Size : Me.Location = New Point(0, 23)

            'Configura Grid
            Call oClsCadNCM.LoadGridHistorico(grdRegra, _
                                              iCodigoNCM)

            Me.Text = "Histórico de Entrada do NCM: " & sCodigoNCM

            'Configura Grid
            Call ConfiguraGrid(grdRegra, Formulario.ImpostoRegra)

            'Seta Focu
            grdRegra.Focus()
            System.Windows.Forms.SendKeys.Send("{UP}")

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

#End Region

End Class
